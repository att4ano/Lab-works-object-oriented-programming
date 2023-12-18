using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.MotherBoard;

public record Chipset
{
    public Chipset(IList<int> rangeFrequency, bool supportsWifiModule, bool supportsXmp)
    {
        Frequency = rangeFrequency;
        SupportsWifiModule = supportsWifiModule;
        SupportsXmp = supportsXmp;
    }

    public IList<int> Frequency { get; init; }
    public bool SupportsWifiModule { get; init; }
    public bool SupportsXmp { get; init; }
}