using System;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceEnvironment.Model.ObstacleInterfaces;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Ship.ShipInterfaces;
using Itmo.ObjectOrientedProgramming.Lab1.TravelServices.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.SpaceEnvironment.Model;

public class Asteroids : IOrdinarySpaceObstacles, IGiveDamageObstacle
{
    private const decimal AsteroidDamagePerOneUnit = 100;

    public Asteroids(int amount)
    {
        Amount = amount;
    }

    public decimal DamagePerOneUnit { get; } = AsteroidDamagePerOneUnit;
    public int Amount { get; }

    public ShipStatus GiveDamage(IBaseShip? ship)
    {
        if (ship is not null)
        {
            ship.TakeDamage(AsteroidDamagePerOneUnit * Amount);
            return new ShipStatus(ship.IsCrewAlive, ship.Hull.Health > 0);
        }
        else
        {
            throw new ArgumentNullException(nameof(ship), "cannot be null");
        }
    }
}