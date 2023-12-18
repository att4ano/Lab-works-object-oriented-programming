using Itmo.ObjectOrientedProgramming.Lab2.Entities.WifiAdapter.Builder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.WifiAdapter;

public interface IWifiAdapter : IComponent
{
    public int WifiVersion { get; init; }
    public bool WithBluetooth { get; init; }
    public BaseConnector.PciE PciE { get; init; }
    public int PowerConsumption { get; init; }

    public WifiAdapterBuilder Debuild(WifiAdapterBuilder wifiAdapterBuilder);
}