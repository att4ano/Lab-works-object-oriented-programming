namespace Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Deflector;

public interface IPhotonicUpgrade : IDeflector
{
    public IDeflector Deflector { get; }
    public int AntiMatterFlashes { get; }

    public void Reflect(int amount);
}