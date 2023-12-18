using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Models.Points;

namespace Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Hull;

public class HullFirstClass : IBaseHull
{
    private const decimal HullFirstClassHealthValue = 400;

    public HullFirstClass()
    {
    }

    public HealthPoints Health { get; private set; } = new HealthPoints(HullFirstClassHealthValue);
    public double GetDamageCoefficient { get; } = 1;
    public double AsteroidDamageCoefficient { get; } = 1;

    public void TakeDamage(HealthPoints takenHealthPoints)
    {
        Health -= takenHealthPoints;
    }
}