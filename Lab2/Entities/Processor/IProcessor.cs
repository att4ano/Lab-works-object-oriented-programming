using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Processor.Builder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Processor;

public interface IProcessor : IComponent
{
    public int CoreAmount { get; init; }
    public int CoreFrequency { get; init; }
    public Socket RequiredSocket { get; init; }
    public IList<int> RamFrequency { get; init; }
    public int HeatDissipation { get; init; }
    public bool WithVideCore { get; init; }
    public int PowerConsumption { get; init; }
    public ProcessorBuilder Debuilder(ProcessorBuilder processorBuilder);
}
