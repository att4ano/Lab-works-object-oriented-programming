using System;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Models.Points;

namespace Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Engine.EngineInterfaces;

public class ImpulseEngineE : IExponentialImpulseEngine
{
    public ImpulseEngineE()
    {
        FuelConsumptionPerOneUnit = new Fuel(30);
    }

    public Fuel FuelConsumptionPerOneUnit { get; }

    public Fuel CountFuelConsumption(int environmentSize)
    {
        return new Fuel(environmentSize * FuelConsumptionPerOneUnit.FuelValue);
    }

    public decimal CountTime(decimal pathLength)
    {
        return (decimal)Math.Log((double)pathLength + 1);
    }
}