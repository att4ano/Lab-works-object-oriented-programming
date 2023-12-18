using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Models.Points;

namespace Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Models;

public interface ITakeDamage
{
    public HealthPoints Health { get; }
    public double GetDamageCoefficient { get; }
    public void TakeDamage(HealthPoints takenHealthPoints);
}
