var target = Argument("target", "Build");
var configuration = Argument("configuration", "Release");


var projectDir = "./PostbankApp/";
var binDir = String.Concat(projectDir, "bin");
var solutionFile = "./PostbankApp/PostbankApp.sln";
var outputDir = Directory(binDir) + Directory(configuration);

var buildSettings = new DotNetBuildSettings
{
    Framework = "netcoreapp3.1",
    Configuration = "Release",
    OutputDirectory = outputDir
};

Task("Clean")
    .Does(() =>
    {
        if (DirectoryExists(outputDir))
        {
            CleanDirectory(outputDir);
        }
    });

Task("Build")
.IsDependentOn("Clean")
.Does(() => {
    DotNetBuild(solutionFile, buildSettings);
});



RunTarget(target);