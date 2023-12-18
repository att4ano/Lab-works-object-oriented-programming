using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Engine.EngineInterfaces;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Hull;

namespace Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Ship.ShipInterfaces;

public interface IBaseShip
{
    public IImpulseEngine ImpulseEngine { get; }
    public IBaseHull Hull { get; }
    public bool IsCrewAlive { get; }

    public void TakeDamage(decimal damage);
}