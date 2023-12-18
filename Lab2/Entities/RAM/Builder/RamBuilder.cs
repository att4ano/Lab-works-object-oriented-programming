using System;
using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.RAM.Builder;

public class RamBuilder
{
    private int _amount;
    private string? _ramName;
    private int _ramSize;
    private IList<RamProfile> _ramJedec;
    private IList<RamProfile> _ramXmp;
    private Ddr? _ddr;
    private int _powerConsumption;
    private string? _formFactor;

    public RamBuilder()
    {
        _ramJedec = new List<RamProfile>();
        _ramXmp = new List<RamProfile>();
    }

    public RamBuilder WithRamSize(int ramSize)
    {
        _ramSize = ramSize;
        return this;
    }

    public RamBuilder WithJedec(RamProfile jedec)
    {
        _ramJedec.Add(jedec);
        return this;
    }

    public RamBuilder WithXmp(RamProfile ramXmp)
    {
        _ramXmp.Add(ramXmp);
        return this;
    }

    public RamBuilder WithDdr(Ddr ddr)
    {
        _ddr = ddr;
        return this;
    }

    public RamBuilder WithPowerConsumption(int powerConsumption)
    {
        _powerConsumption = powerConsumption;
        return this;
    }

    public RamBuilder WithRamName(string ramName)
    {
        _ramName = ramName;
        return this;
    }

    public RamBuilder WithAmount(int amount)
    {
        _amount = amount;
        return this;
    }

    public RamBuilder WithFormfactor(string formFactor)
    {
        _formFactor = formFactor;
        return this;
    }

    public IRam Build()
    {
        if (_ddr is not null && _ramName is not null && _formFactor is not null)
        {
            return new Ram(
                _ramSize,
                _amount,
                _ramJedec,
                _ramXmp,
                _ddr,
                _powerConsumption,
                _ramName,
                _formFactor);
        }

        if (_ddr is null)
        {
            throw new ArgumentNullException(nameof(_ddr), "cannot be null");
        }
        else if (_ramName is null)
        {
            throw new ArgumentNullException(nameof(_ramName), "cannot be null");
        }
        else
        {
            throw new ArgumentNullException(nameof(_formFactor), "cannot be null");
        }
    }
}