// Copyright (c) 2019-2025 wetcon gmbh. All rights reserved.
//
// Wetcon provides this source code under a dual license model 
// designed to meet the development and distribution needs of both 
// commercial distributors (such as OEMs, ISVs and VARs) and open 
// source projects.
//
// For open source projects the source code in this file is covered 
// under GPL V2. 
// See https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html
//
// OEMs (Original Equipment Manufacturers), ISVs (Independent Software 
// Vendors), VARs (Value Added Resellers) and other distributors that 
// combine and distribute commercially licensed software with this 
// source code and do not wish to distribute the source code for the 
// commercially licensed software under version 2 of the GNU General 
// Public License (the "GPL") must enter into a commercial license 
// agreement with wetcon.
//
// This source code is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY, without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

using System;
using System.Collections.Generic;
using Cake.Common;
using Cake.Common.Diagnostics;
using Cake.Common.IO;
using Cake.Common.Solution.Project.Properties;
using Cake.Common.Tools.GitVersion;
using Cake.Common.Tools.MSBuild;
using Cake.Common.Tools.NuGet;
using Cake.Common.Tools.NuGet.Restore;
using Cake.Common.Tools.SignTool;
using Cake.Common.Tools.VSTest;
using Cake.Common.Tools.WiX;
using Cake.Common.Tools.WiX.Heat;
using Cake.Core;
using Cake.Core.IO;
using Cake.Frosting;

namespace Build
{
    public static class Constants
    {
# if PW5
        public const string SolutionPath = "../Build.PW5.sln";
        public const string SetupObjDir = $"../src/Wetcon.PactwarePlugin.OpcUaServer.Setup/PW5/obj";
        public const string SetupMsi = "../artifacts/Wetcon.PactwarePlugin.OpcUaServer.Setup/PW5/OpcUaServer_PW5_Plugin.msi";
        public const string PactwareVersion = "PACTware 5";
        public const string PactwareSubdirectory = "PW5";
#else
        public const string SolutionPath = "../Build.PW6.sln";
        public const string SetupObjDir = $"../src/Wetcon.PactwarePlugin.OpcUaServer.Setup/PW6/obj";
        public const string SetupMsi = "../artifacts/Wetcon.PactwarePlugin.OpcUaServer.Setup/PW6/OpcUaServer_PW6_Plugin.msi";
        public const string PactwareVersion = "PACTware 6";
        public const string PactwareSubdirectory = "PW6";
#endif
    }

    public static class Program
    {
        public static int Main(string[] args)
        {
            return new CakeHost()
                .InstallTool(new Uri("nuget:?package=NuGet.CommandLine&version=5.9.1"))
                .InstallTool(new Uri("nuget:?package=Microsoft.TestPlatform&version=15.9.0"))
                .InstallTool(new Uri("nuget:?package=Wix&version=3.11.1"))
                .InstallTool(new Uri("nuget:?package=GitVersion.CommandLine&version=4.0.0"))
                .UseContext<BuildContext>()
                .Run(args);
        }
    }

    public class BuildContext : FrostingContext
    {
        public string MsBuildConfiguration { get; }
        public bool SignBinaries { get; }
        public SignToolSignSettings SignSettings { get; }

        public BuildContext(ICakeContext context)
            : base(context)
        {
            MsBuildConfiguration = context.Argument("configuration", "Release");
            SignBinaries = false && context.HasArgument("sign"); // todo: enable signing with new certificate            
            context.Information($"Running for {Constants.PactwareVersion}");

            if (SignBinaries)
            {
                var certPath = context.Environment.GetEnvironmentVariable("SignCertPath");
                var password = context.Environment.GetEnvironmentVariable("SignCertPassword");
                var timeStampUri = context.Environment.GetEnvironmentVariable("SignCertTimeStampUri");

                if (certPath == null || password == null || timeStampUri == null)
                {
                    throw new Exception($"At least one of SignCertPath, SignCertPassword or SignCertTimeStampUri environment variables not set.");
                }

                SignSettings = new SignToolSignSettings
                {
                    TimeStampUri = new Uri(timeStampUri),
                    CertPath = certPath,
                    Password = password,
                    DigestAlgorithm = SignToolDigestAlgorithm.Sha1
                };
            }
        }
    }

    [TaskName("Clean")]
    public sealed class CleanTask : FrostingTask<BuildContext>
    {
        public override void Run(BuildContext context)
        {
            var directoriesToClean =
                context.GetDirectories($"../src/**/obj/") +
                context.GetDirectories($"../src/**/bin/") +
                context.GetDirectories($"../tests/**/obj/") +
                context.GetDirectories($"../tests/**/bin/") +
                context.GetDirectories("../artifacts");
            context.Information(string.Join(Environment.NewLine, directoriesToClean));
            context.CleanDirectories(directoriesToClean);
        }
    }

    [TaskName("UpdateVersion")]
    public sealed class UpdateVersionTask : FrostingTask<BuildContext>
    {
        private const string SolutionInfoPath = "../src/SolutionInfo.cs";
        public override void Run(BuildContext context)
        {
            var assemblyVersion = context.GitVersion();
            context.Information($"Calculated assembly version: {assemblyVersion.FullSemVer}");

            context.CreateAssemblyInfo(SolutionInfoPath, new AssemblyInfoSettings
            {
                Version = assemblyVersion.AssemblySemVer,
                FileVersion = assemblyVersion.AssemblySemFileVer,
                InformationalVersion = assemblyVersion.InformationalVersion,
                Product = $"OpcUaServerPlugin",
                Company = "wetcon gmbh",
                Copyright = $"Copyright (c) wetcon gmbh 2019 - {DateTime.UtcNow.Year}"
            });
        }
    }

    [TaskName("PackageRestore")]
    [IsDependentOn(typeof(CleanTask))]
    public sealed class PackageRestoreTask : FrostingTask<BuildContext>
    {
        public override void Run(BuildContext context)
        {
            var filePath = new FilePath(Constants.SolutionPath);
            context.Information($"Restoring {filePath.MakeAbsolute(context.Environment)}...");
            context.NuGetRestore(filePath, new NuGetRestoreSettings
            {
                Verbosity = NuGetVerbosity.Quiet
            });
        }
    }

    [TaskName("Build")]
    [IsDependentOn(typeof(PackageRestoreTask))]
    [IsDependentOn(typeof(UpdateVersionTask))]
    public sealed class BuildTask : FrostingTask<BuildContext>
    {
        public override void Run(BuildContext context)
        {
            var filePath = new FilePath(Constants.SolutionPath);
            context.Information($"Building {filePath.MakeAbsolute(context.Environment)}...");
            context.MSBuild(filePath, new MSBuildSettings
            {
                MaxCpuCount = 0,
                Configuration = context.MsBuildConfiguration,
                ToolVersion = MSBuildToolVersion.VS2022,
                Verbosity = Cake.Core.Diagnostics.Verbosity.Minimal
            });
        }
    }

    [TaskName("Test")]
    [IsDependentOn(typeof(BuildTask))]
    public sealed class TestTask : FrostingTask<BuildContext>
    {
        public override void Run(BuildContext context)
        {
            var tests = context.GetFiles($"../tests/**/bin/{Constants.PactwareSubdirectory}/{context.MsBuildConfiguration}/*.Tests.dll");
            context.Information(string.Join(Environment.NewLine, tests));
            context.VSTest(tests, new VSTestSettings
            {
                Parallel = true,
                Logger = "trx",
                ToolPath = context.Tools.Resolve("vstest.console.exe"),
                TestCaseFilter = "TestCategory!=Integrated",
                ResultsDirectory = $"../TestResults",
                ArgumentCustomization = args => args.Append("/logger:console;verbosity=minimal"),
            });
        }
    }

    [TaskName("SignDlls")]
    [IsDependentOn(typeof(TestTask))]
    public sealed class SignDllsTask : FrostingTask<BuildContext>
    {
        public override bool ShouldRun(BuildContext context) => context.SignBinaries;

        public override void Run(BuildContext context)
        {
            var dlls = context.GetFiles($"../src/Wetcon.PactwarePlugin.OpcUaServer.Plugin/bin/{Constants.PactwareSubdirectory}/{context.MsBuildConfiguration}/**/Wetcon.*.dll");
            context.Sign(dlls, context.SignSettings);
        }
    }

    [TaskName("CopyInstallerFiles")]
    [IsDependentOn(typeof(SignDllsTask))]
    public sealed class CopyInstallerFilesTask : FrostingTask<BuildContext>
    {
        public override void Run(BuildContext context)
        {
            context.CleanDirectory(Constants.SetupObjDir);
            var dlls = context.GetFiles($"../src/Wetcon.PactwarePlugin.OpcUaServer.Plugin/bin/{Constants.PactwareSubdirectory}/{context.MsBuildConfiguration}/**/*.dll");
            context.CopyFiles(dlls, Constants.SetupObjDir);

            var configs = context.GetFiles($"../src/Wetcon.PactwarePlugin.OpcUaServer.Plugin/bin/{Constants.PactwareSubdirectory}/{context.MsBuildConfiguration}/*.config");
            context.CopyFiles(configs, Constants.SetupObjDir);

            var xmls = context.GetFiles($"../src/Wetcon.PactwarePlugin.OpcUaServer.Plugin/bin/{Constants.PactwareSubdirectory}/{context.MsBuildConfiguration}/*.xml");
            context.CopyFiles(xmls, Constants.SetupObjDir);

            var dataDir = context.Directory($"../src/Wetcon.PactwarePlugin.OpcUaServer.Plugin/Resources");
            context.CopyDirectory(dataDir, Constants.SetupObjDir + context.Directory("./Resources"));
        }
    }

    [TaskName("WiXHeat")]
    [IsDependentOn(typeof(CopyInstallerFilesTask))]
    public sealed class WiXHeatTask : FrostingTask<BuildContext>
    {
        public override void Run(BuildContext context)
        {
            var wxsFile = context.File($"../src/Wetcon.PactwarePlugin.OpcUaServer.Setup/{Constants.PactwareSubdirectory}/obj/OpcUaServerPlugin.wxs");
            context.WiXHeat(Constants.SetupObjDir, wxsFile, WiXHarvestType.Dir, new HeatSettings
            {
                DirectoryReferenceId = "INSTALLDIR",
                NoLogo = true,
                AutogeneratedGuid = true,
                ComponentGroupName = "PACTwarePlugin",
                SuppressRootDirectory = true,
                SuppressCom = true,
                SuppressRegistry = true,
                Verbose = true,
            });
        }
    }

    [TaskName("WiXCandle")]
    [IsDependentOn(typeof(WiXHeatTask))]
    public sealed class WiXCandleTask : FrostingTask<BuildContext>
    {
        public override void Run(BuildContext context)
        {
            var wxsFiles = context.GetFiles($"../src/Wetcon.PactwarePlugin.OpcUaServer.Setup/*{Constants.PactwareSubdirectory}.wxs") +
                context.GetFiles($"../src/Wetcon.PactwarePlugin.OpcUaServer.Setup/**/OpcUaServerPlugin.wxs");
            var assemblyVersion = context.GitVersion();
            context.WiXCandle(wxsFiles, new CandleSettings
            {
                OutputDirectory = Constants.SetupObjDir,
                Architecture = Architecture.X86,
                NoLogo = true,
                Defines = new Dictionary<string, string>
                {
                    { "Version", assemblyVersion.MajorMinorPatch },
                    { "SourceDir", "../src/Wetcon.PactwarePlugin.OpcUaServer.Setup/" }
                }
            });
        }
    }

    [TaskName("WiXLight")]
    [IsDependentOn(typeof(WiXCandleTask))]
    public sealed class WiXLightTask : FrostingTask<BuildContext>
    {
        public override void Run(BuildContext context)
        {
            var wixObjFiles = context.GetFiles("../src/Wetcon.PactwarePlugin.OpcUaServer.Setup/**/*.wixobj");
            context.WiXLight(wixObjFiles, new LightSettings
            {
                NoLogo = true,
                OutputFile = Constants.SetupMsi,
                Extensions = new[] { "WixUIExtension", "WixNetFxExtension" },
                RawArguments = "-loc ../src/Wetcon.PactwarePlugin.OpcUaServer.Setup/StringsEn.wxl",
            });
        }
    }

    [TaskName("SignMsi")]
    [IsDependentOn(typeof(WiXLightTask))]
    public sealed class SignMsiTask : FrostingTask<BuildContext>
    {
        public override bool ShouldRun(BuildContext context) => context.SignBinaries;

        public override void Run(BuildContext context)
        {
            var file = context.File(Constants.SetupMsi);
            context.Sign(file, context.SignSettings);
        }
    }

    [TaskName("SetupVersionJson")]
    [IsDependentOn(typeof(SignMsiTask))]
    public sealed class SetupVersionJsonTask : FrostingTask<BuildContext>
    {
        public override void Run(BuildContext context)
        {
            var assemblyVersion = context.GitVersion();
            var json = string.Format("{{ \"version\": \"{0}\" }}", assemblyVersion.MajorMinorPatch);
            System.IO.File.WriteAllText($"../artifacts/Wetcon.PactwarePlugin.OpcUaServer.Setup/{Constants.PactwareSubdirectory}/SetupVersion.json", json);
        }
    }

    [IsDependentOn(typeof(SetupVersionJsonTask))]
    public sealed class Default : FrostingTask
    {
    }
}
