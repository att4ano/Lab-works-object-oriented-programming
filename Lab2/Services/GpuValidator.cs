using Itmo.ObjectOrientedProgramming.Lab2.Entities.Computer;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.WifiAdapter;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services;

public class GpuValidator : IValidator
{
    public GpuValidator() { }
    public AddComponentResult Validate(IComputer computer)
    {
        if (computer.Gpu is not null)
        {
            foreach (PcieSlots pcieSlots in computer.MotherBoard.PciESlots)
            {
                if (pcieSlots.PciE.Version != computer.Gpu.PciE.Version || pcieSlots.Amount <= 0) continue;
                pcieSlots.MakeConnect();
                return new AddComponentResult.Success("Success");
            }

            return new AddComponentResult.Failure("There are no free Pci slots");
        }

        if (computer.Processor.WithVideCore)
        {
            return new AddComponentResult.Success("Success");
        }

        return new AddComponentResult.Failure("there is no GPU and video core");
    }
}