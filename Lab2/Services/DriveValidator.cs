using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Computer;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.WifiAdapter;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services;

public class DriveValidator : IValidator
{
    public DriveValidator() { }

    public AddComponentResult Validate(IComputer computer)
    {
        if (computer.HardDrive is null && computer.SolidStateDrive is null)
        {
            return new AddComponentResult.Failure("There is no drive in computer");
        }

        if (computer.HardDrive is not null)
        {
            foreach (SataSlots sata in computer.MotherBoard.SataSlots)
            {
                if (sata.Sata.Version == computer.HardDrive.Sata.Version && sata.Amount > 0)
                {
                    sata.MakeConnect();
                }
            }

            return new AddComponentResult.Failure("There is no free Sata slots");
        }

        if (computer.SolidStateDrive is null) return new AddComponentResult.Success("Success");
        if (computer.SolidStateDrive.Connector is BaseConnector.PciE pciEConnector)
        {
            foreach (PcieSlots pcie in computer.MotherBoard.PciESlots)
            {
                if (pcie.PciE.Version != pciEConnector.Version || pcie.Amount <= 0) continue;
                pcie.MakeConnect();
                return new AddComponentResult.Success("Success");
            }

            return new AddComponentResult.Failure("There is no free PciE slots");
        }

        if (computer.SolidStateDrive.Connector is not BaseConnector.Sata sataConnector)
            return new AddComponentResult.Failure("There is no free Sata slots");
        {
            foreach (SataSlots sata in computer.MotherBoard.SataSlots)
            {
                if (sata.Sata.Version != sataConnector.Version || sata.Amount <= 0) continue;
                sata.MakeConnect();
                return new AddComponentResult.Success("Success");
            }
        }

        return new AddComponentResult.Failure("There is no free Sata slots");
    }
}