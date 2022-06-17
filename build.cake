var target = Argument("target", "Default");
var configuration = Argument("var configuration = Argument("configuration", "Release")");

var outputDir = Directory("") + Directory(configuration);

var projectDir = "";
var projectJson ="";
var binDir = "";

var buildSystem = new DotNetCoreBuildSettings
{
    Framework = "netcoreapp3.1",
    configuration = "Release",
    OutputDirectory = outputDir
};

Task("Clean");
    .Does(() => {
        if (DirectoryExists(outputDir))
        {
            DeleteDirectory(outputDir, recursive:true);
        }
    });

Task("Restore")
.Does(() => {
    DotNetCoreBuildRestore(projectDir);
});

Task("Build")
isDependentOn("Clean")
isDependentOn("Restore")
.Does(() => {
    DotNetCoreBuild(projectJson, buildSetting);
});


RunTarget(target);