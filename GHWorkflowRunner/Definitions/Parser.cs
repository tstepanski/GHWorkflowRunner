using GHWorkflowRunner.Definitions.Runners;
using GHWorkflowRunner.Definitions.Steps;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace GHWorkflowRunner.Definitions;

public sealed class Parser : IParser
{
    private readonly IDeserializer _deserializer = new DeserializerBuilder()
        .WithNamingConvention(UnderscoredNamingConvention.Instance)
        .WithTypeConverter(RunnerTypeConverter.Instance)
        .WithTypeDiscriminatingNodeDeserializer(options =>
        {
            var keyMappings = new Dictionary<string, Type>
            {
                { "run", typeof(RunStep) },
                { "uses", typeof(UsesStep) }
            };

            options.AddUniqueKeyTypeDiscriminator<AbstractStep>(keyMappings);
        })
        .Build();

    public Task<Workflow> ParseAsync(Stream stream, CancellationToken cancellationToken = default)
    {
        return Task.Run(() =>
        {
            using var streamReader = new StreamReader(stream);

            return _deserializer.Deserialize<Workflow>(streamReader);
        }, cancellationToken);
    }
}