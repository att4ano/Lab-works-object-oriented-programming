using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceEnvironment.Model.ObstacleInterfaces;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Ship.ShipInterfaces;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Models.Points;
using Itmo.ObjectOrientedProgramming.Lab1.TravelServices.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.SpaceEnvironment.Entity;

public class NebulaeSpace : BaseEnvironment
{
    public NebulaeSpace(IReadOnlyCollection<ISpaceNebulaeObstacles>? obstacles, int distance)
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

            if (ship is IBaseShipWithJumpEngine shipWithJumpEngine)
            {
                if (shipWithJumpEngine.JumpEngine.MaxLengthChanel >= Distance)
                {
                    var routeConsumptionStatus = new RouteConsumptionStatus(
                        shipWithJumpEngine.JumpEngine.CountTime(Distance),
                        new Fuel(),
                        shipWithJumpEngine.JumpEngine.CountFuelConsumption(Distance));
                    return new PassingEnvironmentStatus(shipStatus, routeConsumptionStatus, false);
                }
                else
                {
                    return new PassingEnvironmentStatus(shipStatus, new RouteConsumptionStatus(), true);
                }
            }
            else
            {
                return new PassingEnvironmentStatus(shipStatus, new RouteConsumptionStatus(), true);
            }
        }
        else
        {
            throw new ArgumentNullException(nameof(ship), "cannot be null");
        }
    }
}