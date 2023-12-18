using System;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.GPU.Builder;

public class GpuBuilder
{
    private string? _name;
    private Dimensions? _dimension;
    private int _videoMemorySize;
    private BaseConnector.PciE? _pciE;
    private int _frequency;
    private int _powerConsumption;

    public GpuBuilder WithName(string name)
    {
        _name = name;
        return this;
    }

    public GpuBuilder WithDimensions(Dimensions dimensions)
    {
        _dimension = dimensions;
        return this;
    }

    public GpuBuilder WithPowerConsumption(int powerConsumption)
    {
        _powerConsumption = powerConsumption;
        return this;
    }

    public GpuBuilder WithVideoMemorySize(int videoMemorySize)
    {
        _videoMemorySize = videoMemorySize;
        return this;
    }

    public GpuBuilder WithPciE(BaseConnector.PciE pciE)
    {
        _pciE = pciE;
        return this;
    }

    public GpuBuilder WithFrequency(int frequency)
    {
        _frequency = frequency;
        return this;
    }

    public IGpu Build()
    {
        if (_name is not null && _dimension is not null && _pciE is not null)
        {
            return new Gpu(
                _name,
                _dimension,
                _videoMemorySize,
                _pciE,
                _frequency,
                _powerConsumption);
        }

        throw new ArgumentNullException();
    }
}