using Itmo.ObjectOrientedProgramming.Lab2.Entities.WifiAdapter.Builder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.WifiAdapter;

public class WifiAdapter : IWifiAdapter
{
    public WifiAdapter(
        string name,
        int wifiVersion,
        bool withBluetooth,
        BaseConnector.PciE pciE,
        int powerConsumption)
    {
        WifiVersion = wifiVersion;
        WithBluetooth = withBluetooth;
        PciE = pciE;
        PowerConsumption = powerConsumption;
        Name = name;
    }

    public string Name { get; init; }
    public int WifiVersion { get; init; }
    public bool WithBluetooth { get; init; }
    public BaseConnector.PciE PciE { get; init; }
    public int PowerConsumption { get; init; }

    public WifiAdapterBuilder Debuild(WifiAdapterBuilder wifiAdapterBuilder)
    {
        wifiAdapterBuilder.WithName(Name);
        wifiAdapterBuilder.WithVersion(WifiVersion);
        wifiAdapterBuilder.WithBluetooth(WithBluetooth);
        wifiAdapterBuilder.WithPciE(PciE);
        wifiAdapterBuilder.WithPowerConsumption(PowerConsumption);
        return wifiAdapterBuilder;
    }
}