using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;

namespace GHWorkflowRunner.Definitions.Runners;

public sealed class RunnerTypeConverter : IYamlTypeConverter
{
    public static readonly IYamlTypeConverter Instance = new RunnerTypeConverter();

    private RunnerTypeConverter()
    {
    }

    public bool Accepts(Type type)
    {
        return type == typeof(IRunner);
    }

    public object ReadYaml(YamlDotNet.Core.IParser parser, Type type)
    {
        var isScalar = parser.TryConsume<Scalar>(out var scalar);

        if (isScalar)
        {
            return new Named
            {
                Value = scalar!.Value
            };
        }

        throw new NotSupportedException();
    }

    public void WriteYaml(IEmitter emitter, object? value, Type type)
    {
        throw new NotImplementedException();
    }
}