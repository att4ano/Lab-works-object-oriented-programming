using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.ProcessorCooler.Builder;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.ProcessorCooler;

public interface IProcessorCooler : IComponent
{
    public Dimensions Dimension { get; init; }
    public IList<string> SupportedSocket { get; init; }
    public int MaximumDissipatedMassOfHeat { get; init; }

    public ProcessorCoolerBuilder Debuild(ProcessorCoolerBuilder processorCoolerBuilder);
}