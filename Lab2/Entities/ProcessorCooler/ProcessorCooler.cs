using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.ProcessorCooler.Builder;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.ProcessorCooler;

public class ProcessorCooler : IProcessorCooler
{
    public ProcessorCooler(
        string name,
        Dimensions dimension,
        IList<string> supportedSocket,
        int maximumDissipatedMassOfHeat)
    {
        Name = name;
        Dimension = dimension;
        SupportedSocket = supportedSocket;
        MaximumDissipatedMassOfHeat = maximumDissipatedMassOfHeat;
    }

    public string Name { get; init; }
    public Dimensions Dimension { get; init; }
    public IList<string> SupportedSocket { get; init; }
    public int MaximumDissipatedMassOfHeat { get; init; }

    public ProcessorCoolerBuilder Debuild(ProcessorCoolerBuilder processorCoolerBuilder)
    {
        processorCoolerBuilder.WithName(Name);
        processorCoolerBuilder.WithDimension(Dimension);
        foreach (string t in SupportedSocket)
        {
            processorCoolerBuilder.WithSupportedSocket(t);
        }

        processorCoolerBuilder.WithMaximumDissipatedMassOfHeat(MaximumDissipatedMassOfHeat);
        return processorCoolerBuilder;
    }
}