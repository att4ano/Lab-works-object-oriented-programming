using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Processor.Builder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Processor;

public class Processor : IProcessor
{
    public Processor(
        string nameOfProcessor,
        int powerConsumption,
        int coreAmount,
        int coreFrequency,
        Socket requiredSocket,
        IList<int> ramFrequency,
        int heatDissipation,
        bool withVideoCore)
    {
        CoreAmount = coreAmount;
        PowerConsumption = powerConsumption;
        CoreFrequency = coreFrequency;
        RequiredSocket = requiredSocket;
        RamFrequency = ramFrequency;
        HeatDissipation = heatDissipation;
        WithVideCore = withVideoCore;
        Name = nameOfProcessor;
    }

    public string Name { get; init; }
    public int CoreAmount { get; init; }

    public int CoreFrequency { get; init; }

    public Socket RequiredSocket { get; init; }

    public IList<int> RamFrequency { get; init; }

    public int HeatDissipation { get; init; }

    public bool WithVideCore { get; init; }
    public int PowerConsumption { get; init; }

    public ProcessorBuilder Debuilder(ProcessorBuilder processorBuilder)
    {
        processorBuilder.WithName(Name);
        processorBuilder.WithCoreAmount(CoreAmount);
        processorBuilder.WIthCoreFrequency(CoreFrequency);
        processorBuilder.WithRequiredSocket(RequiredSocket);
        processorBuilder.WithRamFrequency(RamFrequency);
        processorBuilder.WithHeatDissipation(HeatDissipation);
        processorBuilder.WithVideoCore(WithVideCore);
        return processorBuilder;
    }
}