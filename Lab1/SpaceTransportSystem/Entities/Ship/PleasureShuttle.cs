using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Engine.EngineInterfaces;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Hull;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Ship.ShipInterfaces;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Models.Points;

namespace Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Ship;

public class PleasureShuttle : IBaseShip
{
    public PleasureShuttle()
    {
    }

    public IImpulseEngine ImpulseEngine { get; } = new ImpulseEngineC();
    public IBaseHull Hull { get; } = new HullFirstClass();
    public bool IsCrewAlive { get; } = true;
    public void TakeDamage(decimal damage)
    {
        damage *= (decimal)Hull.GetDamageCoefficient;
        Hull.TakeDamage(new HealthPoints(damage));
    }
}