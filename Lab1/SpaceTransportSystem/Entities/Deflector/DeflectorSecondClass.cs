using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Models.Points;

namespace Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Deflector;

public class DeflectorSecondClass : IDeflector
{
    private const decimal DeflectorSecondClassHealthValue = 400;
    public DeflectorSecondClass()
    {
    }

    public HealthPoints Health { get; private set; } = new HealthPoints(DeflectorSecondClassHealthValue);

    public double GetDamageCoefficient { get; } = 0.8;

    public void TakeDamage(HealthPoints takenHealthPoints)
    {
        Health -= takenHealthPoints;
    }
}