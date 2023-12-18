using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.WifiAdapter.Builder;

public class WifiAdapterBuilder
{
    private string? _name;
    private int _wifiVersion;
    private bool _withBluetooth;
    private BaseConnector.PciE? _pciE;
    private int _powerConsumption;

    public WifiAdapterBuilder WithName(string name)
    {
        _name = name;
        return this;
    }

    public WifiAdapterBuilder WithVersion(int version)
    {
        _wifiVersion = version;
        return this;
    }

    public WifiAdapterBuilder WithBluetooth(bool withBluetooth)
    {
        _withBluetooth = withBluetooth;
        return this;
    }

    public WifiAdapterBuilder WithPciE(BaseConnector.PciE pciE)
    {
        _pciE = pciE;
        return this;
    }

    public WifiAdapterBuilder WithPowerConsumption(int powerConsumption)
    {
        _powerConsumption = powerConsumption;
        return this;
    }

    public IWifiAdapter Build()
    {
        if (_name is not null && _pciE is not null)
        {
            return new WifiAdapter(
                _name,
                _wifiVersion,
                _withBluetooth,
                _pciE,
                _powerConsumption);
        }

        if (_name is null)
        {
            throw new ArgumentNullException(nameof(_name), "cannot be null");
        }
        else
        {
            throw new ArgumentNullException(nameof(_pciE), "cannot be null");
        }
    }
}