namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.RAM;

public record RamTiming
{
    public RamTiming(int casLatency, int rowAddressToColumnAddressDelay, int rowPrechargeTime, int rowActiveTime)
    {
        CasLatency = casLatency;
        RowAddressToColumnAddressDelay = rowAddressToColumnAddressDelay;
        RowPrechargeTime = rowPrechargeTime;
        RowActiveTime = rowActiveTime;
    }

    public int CasLatency { get; init; }
    public int RowAddressToColumnAddressDelay { get; init; }
    public int RowPrechargeTime { get; init; }
    public int RowActiveTime { get; init; }
}