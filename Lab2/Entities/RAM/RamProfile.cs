namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.RAM;

public record RamProfile
{
    public RamProfile(RamTiming timing, int voltage, int frequency)
    {
        Timing = timing;
        Voltage = voltage;
        Frequency = frequency;
    }

    public RamTiming Timing { get; init; }
    public int Voltage { get; init; }
    public int Frequency { get; init; }
}