using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceEnvironment.Entity;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Ship.ShipInterfaces;
using Itmo.ObjectOrientedProgramming.Lab1.TravelServices.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.TravelServices.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.TravelServices.Services;

public class Route
{
    public Route(IBaseShip? ship, IReadOnlyCollection<BaseEnvironment>? environments)
    {
        if (ship is not null && environments is not null)
        {
            Ship = ship;
            Environments = environments;
            CompleteTime = 0;
        }
        else
        {
            throw new ArgumentNullException(nameof(ship), "cannot be null");
        }
    }

    public decimal CompleteTime { get; private set; }
    public ShipStatus RouteShipStatus { get; private set; } = new ShipStatus();
    public bool IsShipLost { get; private set; }
    public decimal MoneyForFuel { get; private set; } = 0;

    public IBaseShip Ship { get; private init; }
    public IReadOnlyCollection<BaseEnvironment> Environments { get; private set; }

    public void PassRoute()
    {
        foreach (BaseEnvironment environment in Environments)
        {
            PassingEnvironmentStatus passingEnvironmentStatus = environment.PassEnvironment(Ship);
            if (passingEnvironmentStatus is { Status: { IsCrewAlive: true, IsShipAlive: true }, IsShipLost: false })
            {
                CompleteTime += passingEnvironmentStatus.ConsumptionStatus.Time;
                var fuelExchange = new FuelExchange(
                    passingEnvironmentStatus.ConsumptionStatus.OrdinaryFuelConsumption.FuelValue,
                    passingEnvironmentStatus.ConsumptionStatus.GravityFuelConsumption.FuelValue);
                MoneyForFuel += fuelExchange.OrdinaryFuelPrice + fuelExchange.GravityFuelPrice;
            }
            else
            {
                CompleteTime = 0;
                RouteShipStatus = passingEnvironmentStatus.Status;
                IsShipLost = passingEnvironmentStatus.IsShipLost;
                break;
            }
        }
    }
}
