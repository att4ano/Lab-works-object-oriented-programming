using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Drive.DriverBuilder;

public class HddBuilder
{
    private string? _name;
    private BaseConnector.Sata? _sata;
    private int _memorySize;
    private int _powerConsumption;
    private int _spindleRotationSpeed;

    public HddBuilder WithName(string name)
    {
        _name = name;
        return this;
    }

    public HddBuilder WithMemorySize(int memorySize)
    {
        _memorySize = memorySize;
        return this;
    }

    public HddBuilder WithPowerConsumption(int powerConsumption)
    {
        _powerConsumption = powerConsumption;
        return this;
    }

    public HddBuilder WithSpindleRotationSpeed(int spindleRotationSpeed)
    {
        _spindleRotationSpeed = spindleRotationSpeed;
        return this;
    }

    public HddBuilder WithSata(BaseConnector.Sata sata)
    {
        _sata = sata;
        return this;
    }

    public IHardDrive Build()
    {
        if (_name is not null && _sata is not null)
        {
            return new HardDrive(
                _name,
                _sata,
                _memorySize,
                _powerConsumption,
                _spindleRotationSpeed);
        }

        if (_name is null)
        {
            throw new ArgumentNullException(nameof(_name), "cannot be null");
        }

        throw new ArgumentNullException(nameof(_sata), "cannot be null");
    }
}