using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceEnvironment.Model.ObstacleInterfaces;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Ship.ShipInterfaces;
using Itmo.ObjectOrientedProgramming.Lab1.TravelServices.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.SpaceEnvironment.Entity;

public abstract class BaseEnvironment
{
    protected BaseEnvironment(IReadOnlyCollection<IObstacle>? obstacles, int distance)
    {
        if (obstacles is not null && distance > 0)
        {
            Obstacles = obstacles;
            Distance = distance;
        }
        else
        {
            if (obstacles is null)
            {
                throw new ArgumentNullException(nameof(obstacles), "cannot be null");
            }
            else
            {
                throw new ArgumentException("cannot be null", nameof(distance));
            }
        }
    }

    public IReadOnlyCollection<IObstacle> Obstacles { get; }
    public int Distance { get; }

    public abstract PassingEnvironmentStatus PassEnvironment(IBaseShip? ship);
}