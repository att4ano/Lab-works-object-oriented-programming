using Itmo.ObjectOrientedProgramming.Lab2.Entities.Computer;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services;

public class RamValidatorConnect : IValidator
{
    public RamValidatorConnect() { }

    public AddComponentResult Validate(IComputer computer)
    {
        if (computer.Ram.Ddr == computer.MotherBoard.DdrStandart &&
            computer.Ram.Amount <= computer.MotherBoard.AmountRamSlots)
        {
            return new AddComponentResult.Success("Success");
        }

        return new AddComponentResult.Failure("Ram doesn't fit motherboard");
    }
}