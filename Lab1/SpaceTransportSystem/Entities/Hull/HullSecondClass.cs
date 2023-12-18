using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Models.Points;

namespace Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Hull;

public class HullSecondClass : IBaseHull
{
    private const decimal HullSecondClassHealthValue = 400;
    public HullSecondClass()
    {
    }

    public HealthPoints Health { get; private set; } = new HealthPoints(HullSecondClassHealthValue);
    public double GetDamageCoefficient { get; } = 0.7;
    public double AsteroidDamageCoefficient { get; } = 1.6;

    public void TakeDamage(HealthPoints takenHealthPoints)
    {
        Health -= takenHealthPoints;
    }
}