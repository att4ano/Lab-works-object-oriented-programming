using Itmo.ObjectOrientedProgramming.Lab2.Entities.Computer;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services;

public class ProcessorCoolerValidator : IValidator
{
    public ProcessorCoolerValidator() { }

    public AddComponentResult Validate(IComputer computer)
    {
        if (computer.ProcessorCooler.MaximumDissipatedMassOfHeat >= computer.Processor.HeatDissipation)
        {
            return new AddComponentResult.Success("Success");
        }

        return new AddComponentResult.HeatDissipationWarning("Disclaimer of warranty obligations");
    }
}