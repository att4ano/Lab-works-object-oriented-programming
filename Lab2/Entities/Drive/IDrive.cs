namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Drive;

public interface IDrive : IComponent
{
    public int MemorySize { get; init; }
    public int PowerConsumption { get; init; }
}