using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Models.Points;

namespace Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Deflector;

public class PhotonicDeflector : IPhotonicUpgrade
{
    public PhotonicDeflector(IDeflector deflector)
    {
        Deflector = deflector;
        GetDamageCoefficient = Deflector.GetDamageCoefficient;
        Health = Deflector.Health;
    }

    public IDeflector Deflector { get; }
    public double GetDamageCoefficient { get; }
    public int AntiMatterFlashes { get; private set; } = 3;

    public HealthPoints Health { get; }

    public void Reflect(int amount)
    {
        AntiMatterFlashes -= amount;
    }

    public void TakeDamage(HealthPoints takenHealthPoints)
    {
        Deflector.TakeDamage(takenHealthPoints);
    }
}