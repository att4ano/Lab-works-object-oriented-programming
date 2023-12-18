namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.PowerModule;

public class PowerModule : IPowerModule
{
    public PowerModule(string name, int peakLoad)
    {
        Name = name;
        PeakLoad = peakLoad;
    }

    public string Name { get; init; }
    public int PeakLoad { get; init; }
}