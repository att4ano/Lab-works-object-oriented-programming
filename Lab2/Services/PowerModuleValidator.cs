using Itmo.ObjectOrientedProgramming.Lab2.Entities.Computer;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services;

public class PowerModuleValidator : IValidator
{
    public PowerModuleValidator() { }

    public AddComponentResult Validate(IComputer computer)
    {
        int resultPowerConsumption =
            computer.Processor.PowerConsumption + (computer.Ram.Amount * computer.Ram.PowerConsumption);
        if (computer.HardDrive is not null)
        {
            resultPowerConsumption += computer.HardDrive.PowerConsumption;
        }

        if (computer.SolidStateDrive is not null)
        {
            resultPowerConsumption += computer.SolidStateDrive.PowerConsumption;
        }

        if (computer.WifiAdapter is not null)
        {
            resultPowerConsumption += computer.WifiAdapter.PowerConsumption;
        }

        if (computer.Gpu is not null)
        {
            resultPowerConsumption += computer.Gpu.PowerConsumption;
        }

        if (resultPowerConsumption > computer.PowerModule.PeakLoad)
        {
            return new AddComponentResult.Failure("The peak power of the power supply has been exceeded");
        }

        if (resultPowerConsumption > (computer.PowerModule.PeakLoad * 0.8))
        {
            return new AddComponentResult.PowerConsumptionWarning("Not enough power from power module");
        }

        return new AddComponentResult.Success("Success");
    }
}