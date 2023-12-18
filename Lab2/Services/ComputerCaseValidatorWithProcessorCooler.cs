using Itmo.ObjectOrientedProgramming.Lab2.Entities.Computer;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services;

public class ComputerCaseValidatorWithProcessorCooler : IValidator
{
    public ComputerCaseValidatorWithProcessorCooler() { }
    public AddComponentResult Validate(IComputer computer)
    {
        if (computer.ProcessorCooler.Dimension <= computer.ComputerCase.Dimension)
        {
            return new AddComponentResult.Success("Success");
        }

        return new AddComponentResult.Failure("Processor cooler doesn't fit in computer case");
    }
}