using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Models.Points;

namespace Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Hull;

public class HullThirdClass : IBaseHull
{
    private const decimal HullThirdClassHealthValue = 400;
    public HullThirdClass()
    {
    }

    public HealthPoints Health { get; private set; } = new HealthPoints(HullThirdClassHealthValue);
    public double GetDamageCoefficient { get; } = 0.5;

    public double AsteroidDamageCoefficient { get; } = 1;

    public void TakeDamage(HealthPoints takenHealthPoints)
    {
        Health -= takenHealthPoints;
    }
}