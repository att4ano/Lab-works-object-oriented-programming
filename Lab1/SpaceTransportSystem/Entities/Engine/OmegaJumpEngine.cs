using System;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Engine.EngineInterfaces;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Models.Points;

namespace Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Engine;

public class OmegaJumpEngine : IJumpEngine
{
    private const decimal Speed = 150;
    public OmegaJumpEngine()
    {
    }

    public Fuel FuelConsumptionPerOneUnit { get; } = new Fuel(100);

    public decimal MaxLengthChanel { get; } = 1000;

    public Fuel CountFuelConsumption(int environmentSize)
    {
        return new Fuel((decimal)Math.Log((double)FuelConsumptionPerOneUnit.FuelValue) *
                        FuelConsumptionPerOneUnit.FuelValue * environmentSize);
    }

    public decimal CountTime(decimal pathLength)
    {
        return pathLength / Speed;
    }
}