using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Drive.DriverBuilder;

public class SsdBuilder
{
    private string? _name;
    private int _memorySize;
    private int _powerConsumption;
    private BaseConnector? _connector;
    private int _maxWorkSpeed;

    public SsdBuilder WithName(string name)
    {
        _name = name;
        return this;
    }

    public SsdBuilder WithMemorySize(int size)
    {
        _memorySize = size;
        return this;
    }

    public SsdBuilder WithPowerConsumption(int powerConsumption)
    {
        _powerConsumption = powerConsumption;
        return this;
    }

    public SsdBuilder WithConnector(BaseConnector connector)
    {
        _connector = connector;
        return this;
    }

    public SsdBuilder WithMaxWorkSpeed(int maxWorkSpeed)
    {
        _maxWorkSpeed = maxWorkSpeed;
        return this;
    }

    public ISolidStateDrive Build()
    {
        if (_name is not null && _connector is not null)
        {
            return new SolidStateDrive(
                _name,
                _memorySize,
                _powerConsumption,
                _connector,
                _maxWorkSpeed);
        }

        if (_name is null)
        {
            throw new ArgumentNullException(nameof(_name), "cannot be null");
        }

        throw new ArgumentNullException(nameof(_connector), "cannot be null");
    }
}