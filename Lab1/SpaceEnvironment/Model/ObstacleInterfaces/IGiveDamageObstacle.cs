using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Ship.ShipInterfaces;
using Itmo.ObjectOrientedProgramming.Lab1.TravelServices.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.SpaceEnvironment.Model.ObstacleInterfaces;

public interface IGiveDamageObstacle : IObstacle
{
    public decimal DamagePerOneUnit { get; }
    public ShipStatus GiveDamage(IBaseShip? ship);
}