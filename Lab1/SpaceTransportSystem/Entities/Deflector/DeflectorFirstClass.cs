using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Models.Points;

namespace Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Deflector;

public class DeflectorFirstClass : IDeflector
{
    private const decimal DeflectorFirstClassHealthValue = 400;

    public DeflectorFirstClass()
    {
    }

    public double GetDamageCoefficient { get; } = 1;

    public HealthPoints Health { get; private set; } = new HealthPoints(DeflectorFirstClassHealthValue);
    public double AsteroidDamageCoefficient { get; } = 2;

    public void TakeDamage(HealthPoints takenHealthPoints)
    {
        Health -= takenHealthPoints;
    }
}