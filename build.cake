#tool "nuget:?package=Microsoft.TestPlatform&version=15.9.0"
#tool "nuget:?package=Wix&version=3.11.1"
#tool "nuget:?package=GitVersion.CommandLine&version=4.0.0"

///////////////////////////////////////////////////////////////////////////////
// ARGUMENTS
///////////////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");
bool signBinaries = HasArgument("sign");

///////////////////////////////////////////////////////////////////////////////
// PREPARATION
///////////////////////////////////////////////////////////////////////////////

var solution = "./Wetcon.PactwarePlugin.OpcUaServer.sln";
var setupObjDir = Directory($"./src/Wetcon.PactwarePlugin.OpcUaServer.Setup/obj");
var setupMsi = "./artifacts/Wetcon.PactwarePlugin.OpcUaServer.Setup/OpcUaServer_PW5_Plugin.msi";

GitVersion gitVersion;
SignToolSignSettings signToolSignSettings;

Setup(context => 
{
    gitVersion = GitVersion();
    Information($"Calculated version: {gitVersion.FullSemVer}");

    if (signBinaries)
    {
        string certPath = EnvironmentVariable("SignCertPath");
        string password = EnvironmentVariable("SignCertPassword");
        string timeStampUri = EnvironmentVariable("SignCertTimeStampUri");

        if (certPath == null || password == null || timeStampUri == null) 
        {
            throw new Exception($"At least one of SignCertPath, SignCertPassword or SignCertTimeStampUri environment variables not set.");
        }

        Information($"Signing binaries with certificate: \"{certPath}\", TimeStamp URI: \"{timeStampUri}\"");
        signToolSignSettings = new SignToolSignSettings 
        {
            TimeStampUri = new Uri(timeStampUri),
            CertPath = certPath,
            Password = password
        };
    }
    else 
    {
        Information($"Binaries will not be signed.");
    }
});


///////////////////////////////////////////////////////////////////////////////
// TASKS
///////////////////////////////////////////////////////////////////////////////

Task("Clean")
    .Does(() => 
{
    var directoriesToClean = GetDirectories($"./**/obj/{configuration}")
        .Concat(GetDirectories($"./**/bin/{configuration}"))
        .Concat(GetDirectories($"./src/Wetcon.PactwarePlugin.OpcUaServer.Setup/**/obj"))
        .Concat(GetDirectories($"./src/Wetcon.PactwarePlugin.OpcUaServer.Setup/**/bin"))
        .Concat(GetDirectories("./artifacts"));
    
    CleanDirectories(directoriesToClean);
});

Task("UpdateVersion")
    .Does(() =>
{
    var solutionInfo = "./src/SolutionInfo.cs";

    CreateAssemblyInfo(solutionInfo, new AssemblyInfoSettings 
    {
        Version = gitVersion.AssemblySemVer,
        FileVersion = gitVersion.AssemblySemFileVer,
        InformationalVersion = gitVersion.InformationalVersion,
        Product = "PACTware OpcUaServerPlugin",
        Company  = "wetcon gmbh",
        Copyright = $"Copyright (c) wetcon gmbh 2019 - {DateTime.UtcNow.Year}"
    });
});

Task("PackageRestore")
    .Does(() => 
{
    var settings = new NuGetRestoreSettings 
    {
        Verbosity = NuGetVerbosity.Quiet
    };

    NuGetRestore(solution, settings);
});

Task("Compile")
    .IsDependentOn("UpdateVersion")
    .IsDependentOn("PackageRestore")
    .Does(() => 
{
    MSBuild(solution, settings => {
        settings
            .SetMaxCpuCount(0) // Auto detect number of CPUs for parallel build.
            .SetConfiguration(configuration)
            .UseToolVersion(MSBuildToolVersion.VS2019)
            .SetVerbosity(Verbosity.Minimal);
    });
});


Task("RunUnitTests")
    .IsDependentOn("Compile")
    .Does(() => 
{
    var tests = GetFiles($"./tests/**/bin/{configuration}/**/*.Tests.dll");
    VSTest(tests, new VSTestSettings 
    {
        Parallel = true,
        Logger = "trx",
	    ToolPath = Context.Tools.Resolve("vstest.console.exe"),
	    TestCaseFilter = "TestCategory!=Integrated",
        ArgumentCustomization = args => args.Append("/logger:console;verbosity=minimal"),
    });
});

Task("SignDlls")
    .WithCriteria(signBinaries)
    .Does(() => 
{
     var dlls = GetFiles($"./src/Wetcon.PactwarePlugin.OpcUaServer.Plugin/bin/{configuration}/**/Wetcon.*.dll");
     Sign(dlls, signToolSignSettings);
});

Task("CopyInstallerFiles")
    .IsDependentOn("SignDlls")
    .Does(() => 
{
    CleanDirectory(setupObjDir);

    var dlls = GetFiles($"./src/Wetcon.PactwarePlugin.OpcUaServer.Plugin/bin/{configuration}/**/*.dll");
    CopyFiles(dlls, setupObjDir);

    var configs = GetFiles($"./src/Wetcon.PactwarePlugin.OpcUaServer.Plugin/bin/{configuration}/*.config");
    CopyFiles(configs, setupObjDir);

    var xmls = GetFiles($"./src/Wetcon.PactwarePlugin.OpcUaServer.Plugin/bin/{configuration}/*.xml");
    CopyFiles(xmls, setupObjDir);

    var dataDir = Directory($"./src/Wetcon.PactwarePlugin.OpcUaServer.Plugin/Resources");
    CopyDirectory(dataDir, setupObjDir + Directory("./Resources"));    
});

Task("WiXHeat")
    .IsDependentOn("CopyInstallerFiles")
    .Does(() => 
{    
    var wxsFile = File($"./src/Wetcon.PactwarePlugin.OpcUaServer.Setup/obj/OpcUaServerPlugin.wxs");

    WiXHeat(setupObjDir, wxsFile, WiXHarvestType.Dir, new HeatSettings 
    {
        DirectoryReferenceId  = "INSTALLDIR",
        NoLogo = true,
        AutogeneratedGuid = true,
        ComponentGroupName = "PACTwarePlugin",
        SuppressRootDirectory = true,
        SuppressCom = true,
        SuppressRegistry = true
    });
});

Task("WiXCandle")
    .IsDependentOn("WiXHeat")
    .Does(() => 
{
    var wxsFiles = GetFiles($"./src/Wetcon.PactwarePlugin.OpcUaServer.Setup/**/*.wxs");
    WiXCandle(wxsFiles, new CandleSettings 
    {        
        OutputDirectory = setupObjDir,
        Architecture = Architecture.X86,
        NoLogo = true,
        Defines = new Dictionary<string, string> 
        {
            { "Version", gitVersion.MajorMinorPatch },
            { "SourceDir", "./src/Wetcon.PactwarePlugin.OpcUaServer.Setup/" }
        }
    });
});

Task("WiXLight")
    .IsDependentOn("WiXCandle")
    .Does(() =>
{  
    var wixObjFiles = GetFiles("./src/Wetcon.PactwarePlugin.OpcUaServer.Setup/**/*.wixobj");
    WiXLight(wixObjFiles, new LightSettings 
    {
        NoLogo = true,
        OutputFile = setupMsi,
        Extensions = new[] { "WixUIExtension", "WixNetFxExtension" },
        RawArguments = "-loc ./src/Wetcon.PactwarePlugin.OpcUaServer.Setup/StringsEn.wxl",
    });
});

Task("SignMsi")
    .WithCriteria(signBinaries)
    .IsDependentOn("WixLight")
    .Does(() => 
{    
    var file = File(setupMsi);
    Sign(file, signToolSignSettings);
});

Task("SetupVersionJson")
    .Does(() => 
{
    string json = string.Format("{{ \"version\": \"{0}\" }}", gitVersion.MajorMinorPatch);
    System.IO.File.WriteAllText("./artifacts/Wetcon.PactwarePlugin.OpcUaServer.Setup/SetupVersion.json", json);
});

///////////////////////////////////////////////////////////////////////////////
// TARGETS
///////////////////////////////////////////////////////////////////////////////

Task("Build")
    .IsDependentOn("Clean")
    .IsDependentOn("RunUnitTests")
    .IsDependentOn("WixLight")
    .IsDependentOn("SignMsi")
    .IsDependentOn("SetupVersionJson");;

Task("Default")
    .IsDependentOn("RunUnitTests");

Task("Installer")
    .IsDependentOn("Compile")
    .IsDependentOn("RunUnitTests")
    .IsDependentOn("WixLight")
    .IsDependentOn("SignMsi")
    .IsDependentOn("SetupVersionJson");

RunTarget(target);
