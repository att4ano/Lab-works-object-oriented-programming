namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.PowerModule;

public interface IPowerModule : IComponent
{
    public int PeakLoad { get; init; }
}