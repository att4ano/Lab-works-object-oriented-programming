using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Ship.ShipInterfaces;
using Itmo.ObjectOrientedProgramming.Lab1.TravelServices.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.SpaceEnvironment.Model.ObstacleInterfaces;

public interface IDamageToCrew : IObstacle
{
    public ShipStatus MakeDamageCrew(IBaseShip? ship);
}