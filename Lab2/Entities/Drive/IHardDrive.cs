using Itmo.ObjectOrientedProgramming.Lab2.Entities.Drive.DriverBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Drive;

public interface IHardDrive : IDrive
{
    public int SpindleRotationSpeed { get; init; }
    public BaseConnector.Sata Sata { get; init; }

    public HddBuilder Debuild(HddBuilder hddBuilder);
}