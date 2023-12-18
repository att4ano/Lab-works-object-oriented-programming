using Itmo.ObjectOrientedProgramming.Lab2.Entities.Drive.DriverBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Drive;

public class HardDrive : IHardDrive
{
    public HardDrive(
        string name,
        BaseConnector.Sata sata,
        int memorySize,
        int powerConsumption,
        int spindleRotationSpeed)
    {
        Name = name;
        Sata = sata;
        MemorySize = memorySize;
        PowerConsumption = powerConsumption;
        SpindleRotationSpeed = spindleRotationSpeed;
    }

    public string Name { get; init; }
    public BaseConnector.Sata Sata { get; init; }
    public int MemorySize { get; init; }
    public int PowerConsumption { get; init; }
    public int SpindleRotationSpeed { get; init; }

    public HddBuilder Debuild(HddBuilder hddBuilder)
    {
        hddBuilder.WithName(Name);
        hddBuilder.WithSata(Sata);
        hddBuilder.WithMemorySize(MemorySize);
        hddBuilder.WithPowerConsumption(PowerConsumption);
        hddBuilder.WithSpindleRotationSpeed(SpindleRotationSpeed);
        return hddBuilder;
    }
}