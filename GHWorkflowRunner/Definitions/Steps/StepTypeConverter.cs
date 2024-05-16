using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;

namespace GHWorkflowRunner.Definitions.Steps;

public sealed class StepTypeConverter : IYamlTypeConverter
{
    public bool Accepts(Type type)
    {
        return type == typeof(AbstractStep);
    }

    public object? ReadYaml(YamlDotNet.Core.IParser parser, Type type)
    {
        var mappingStart = parser.Consume<MappingStart>();

        var isRunCommand = parser.TryFindMappingEntry(scalar => scalar is { IsKey: true, Value: "run" }, out _, out _);

        throw new NotSupportedException();
    }

    public void WriteYaml(IEmitter emitter, object? value, Type type)
    {
        throw new NotImplementedException();
    }
}