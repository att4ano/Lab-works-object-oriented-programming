using System;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceEnvironment.Model.ObstacleInterfaces;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Ship.ShipInterfaces;
using Itmo.ObjectOrientedProgramming.Lab1.TravelServices.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.SpaceEnvironment.Model;

public record SpaceWhales : INitrineNebulaeObstacles, IObstaclesWithEmitterFear, IGiveDamageObstacle
{
    private const decimal SpaceWhaleDamagePerOneUnit = 1050;

    public SpaceWhales(int amount)
    {
        Amount = amount;
    }

    public decimal DamagePerOneUnit { get; set; } = SpaceWhaleDamagePerOneUnit;
    public int Amount { get; private set; }

    public ShipStatus GiveDamage(IBaseShip? ship)
    {
        if (ship is not null)
        {
            if (ship is not IBaseShipWithAntinitrineEmitter)
            {
                ship.TakeDamage(SpaceWhaleDamagePerOneUnit * Amount);
                return new ShipStatus(ship.IsCrewAlive, ship.Hull.Health > 0);
            }
            else
            {
                return new ShipStatus(true, true);
            }
        }
        else
        {
            throw new ArgumentNullException(nameof(ship), "cannot be null");
        }
    }
}