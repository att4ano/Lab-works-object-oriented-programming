using System;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceEnvironment.Model.ObstacleInterfaces;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Ship.ShipInterfaces;
using Itmo.ObjectOrientedProgramming.Lab1.TravelServices.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.SpaceEnvironment.Model;

public record Meteorites : IOrdinarySpaceObstacles, IGiveDamageObstacle
{
    private const decimal MeteoriteDamagePerOneUnit = 400;
    public Meteorites(int amount)
    {
        Amount = amount;
    }

    public decimal DamagePerOneUnit { get; } = MeteoriteDamagePerOneUnit;
    public int Amount { get; }

    public ShipStatus GiveDamage(IBaseShip? ship)
    {
        if (ship is not null)
        {
            ship.TakeDamage(MeteoriteDamagePerOneUnit * Amount);
            return new ShipStatus(ship.IsCrewAlive, ship.Hull.Health > 0);
        }
        else
        {
            throw new ArgumentNullException(nameof(ship), "cannot be null");
        }
    }
}
