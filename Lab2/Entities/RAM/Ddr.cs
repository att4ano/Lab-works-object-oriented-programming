namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.RAM;

public record Ddr
{
    public Ddr(int ddrVersion)
    {
        DdrVersion = ddrVersion;
    }

    public int DdrVersion { get; init; }
}