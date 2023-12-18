using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Engine.EngineInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Ship.ShipInterfaces;

public interface IBaseShipWithJumpEngine : IBaseShip
{
    public IJumpEngine JumpEngine { get; }
}
