using Itmo.ObjectOrientedProgramming.Lab2.Entities.Computer;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.WifiAdapter;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services;

public class WifiAdapterValidator : IValidator
{
    public WifiAdapterValidator() { }

    public AddComponentResult Validate(IComputer computer)
    {
        if (computer.MotherBoard.MotherBoardChipset.SupportsWifiModule && computer.WifiAdapter is not null)
        {
            return new AddComponentResult.Failure("Network equipment conflict");
        }

        if (!computer.MotherBoard.MotherBoardChipset.SupportsWifiModule && computer.WifiAdapter is not null)
        {
            foreach (PcieSlots pcieSlots in computer.MotherBoard.PciESlots)
            {
                if (pcieSlots.PciE.Version == computer.WifiAdapter.PciE.Version)
                {
                    return new AddComponentResult.Success("Success");
                }
            }

            return new AddComponentResult.Failure("There are no free Pci slots");
        }

        return new AddComponentResult.Success("Success");
    }
}