using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Deflector;

namespace Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Ship.ShipInterfaces;

public interface IBaseShipWithDeflector : IBaseShip
{
    public IDeflector Deflector { get; }

    public void MakePhotonic();
}