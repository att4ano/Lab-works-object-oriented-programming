using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Computer;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services;

public class RamFrequencyValidator : IValidator
{
    public RamFrequencyValidator() { }

    public AddComponentResult Validate(IComputer computer)
    {
        if (FindJedecInProcessor(computer) && FindJedecInMotherBoard(computer))
        {
            return new AddComponentResult.Success("Success");
        }

        if (computer.MotherBoard.MotherBoardChipset.SupportsXmp)
        {
            if (FindXmpInProcessor(computer))
            {
                return new AddComponentResult.Success("Success");
            }
        }

        return new AddComponentResult.Failure("RAM doesn't fit to the motherboard and process ");
    }

    private static bool FindJedecInMotherBoard(IComputer computer)
    {
        return (from jedec in computer.Ram.RamJedec
            from frequency in computer.MotherBoard.MotherBoardChipset.Frequency
            where jedec.Frequency == frequency
            select jedec).Any();
    }

    private static bool FindJedecInProcessor(IComputer computer)
    {
        return (from jedec in computer.Ram.RamJedec
            from frequency in computer.Processor.RamFrequency
            where jedec.Frequency == frequency
            select jedec).Any();
    }

    private static bool FindXmpInProcessor(IComputer computer)
    {
        return (from xmp in computer.Ram.RamXmp
            from frequency in computer.Processor.RamFrequency
            where xmp.Frequency == frequency
            select xmp).Any();
    }
}