using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Models.Points;

namespace Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Deflector;

public class DeflectorThirdClass : IDeflector
{
    private const decimal DeflectorThirdClassHealthValue = 400;
    public DeflectorThirdClass()
    {
    }

    public HealthPoints Health { get; private set; } = new HealthPoints(DeflectorThirdClassHealthValue);
    public double AsteroidDamageCoefficient { get; } = 1;

    public double GetDamageCoefficient { get; } = 0.5;

    public void TakeDamage(HealthPoints takenHealthPoints)
    {
        Health -= takenHealthPoints;
    }
}