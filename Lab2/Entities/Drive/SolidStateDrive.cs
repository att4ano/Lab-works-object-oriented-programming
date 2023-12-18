using Itmo.ObjectOrientedProgramming.Lab2.Entities.Drive.DriverBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Drive;

public class SolidStateDrive : ISolidStateDrive
{
    public SolidStateDrive(
        string name,
        int memorySize,
        int powerConsumption,
        BaseConnector connector,
        int maxWorkSpeed)
    {
        Name = name;
        MemorySize = memorySize;
        PowerConsumption = powerConsumption;
        Connector = connector;
        MaxWorkSpeed = maxWorkSpeed;
    }

    public string Name { get; init; }
    public int MemorySize { get; init; }
    public int PowerConsumption { get; init; }
    public BaseConnector Connector { get; init; }
    public int MaxWorkSpeed { get; init; }

    public SsdBuilder Debuild(SsdBuilder ssdBuilder)
    {
        ssdBuilder.WithName(Name);
        ssdBuilder.WithMemorySize(MemorySize);
        ssdBuilder.WithPowerConsumption(PowerConsumption);
        ssdBuilder.WithConnector(Connector);
        ssdBuilder.WithMaxWorkSpeed(MaxWorkSpeed);
        return ssdBuilder;
    }
}