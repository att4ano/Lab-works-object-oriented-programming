using Itmo.ObjectOrientedProgramming.Lab2.Entities.Drive.DriverBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Drive;

public interface ISolidStateDrive : IDrive
{
    public BaseConnector Connector { get; init; }
    public int MaxWorkSpeed { get; init; }

    public SsdBuilder Debuild(SsdBuilder ssdBuilder);
}