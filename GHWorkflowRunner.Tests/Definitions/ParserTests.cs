using GHWorkflowRunner.Definitions;

namespace GHWorkflowRunner.Tests.Definitions;

public sealed class ParserTests
{
    [Theory]
    [InlineData("BasicCSharp.yml")]
    public async Task ParseAsync_GivenWorkflowFile_ReturnsWorkflowAsync(string fileName)
    {
        var parser = new Parser();
        var currentDirectory = Directory.GetCurrentDirectory();
        var filePath = Path.Join(currentDirectory, "TestFiles", fileName);

        await using var fileStream = File.OpenRead(filePath);

        var result = await parser.ParseAsync(fileStream);

        Assert.IsAssignableFrom<Workflow>(result);
    }
}