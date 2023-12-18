using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceEnvironment.Model.ObstacleInterfaces;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Ship.ShipInterfaces;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Models.Points;
using Itmo.ObjectOrientedProgramming.Lab1.TravelServices.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.SpaceEnvironment.Entity;

public class OrdinarySpace : BaseEnvironment
{
    public OrdinarySpace(IReadOnlyCollection<IOrdinarySpaceObstacles>? obstacles, int distance)
        : base(obstacles, distance)
    {
    }

    public override PassingEnvironmentStatus PassEnvironment(IBaseShip? ship)
    {
        if (ship is not null)
        {
            var shipStatus = new ShipStatus();
            foreach (IObstacle obstacle in Obstacles)
            {
                if (obstacle is IDamageToCrew damageToCrewObstacle)
                {
                    shipStatus = damageToCrewObstacle.MakeDamageCrew(ship);
                    if (shipStatus is not { IsShipAlive: true, IsCrewAlive: true })
                    {
                        return new PassingEnvironmentStatus(shipStatus, new RouteConsumptionStatus(), false);
                    }
                }
            }

            var routeConsumptionStatus = new RouteConsumptionStatus(
                ship.ImpulseEngine.CountTime(Distance),
                ship.ImpulseEngine.CountFuelConsumption(Distance),
                new Fuel());
            return new PassingEnvironmentStatus(shipStatus, routeConsumptionStatus, false);
        }
        else
        {
            throw new ArgumentNullException(nameof(ship), "cannot be null");
        }
    }
}