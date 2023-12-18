using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Engine.EngineInterfaces;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Models.Points;

namespace Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Engine;

public class AlphaJumpEngine : IJumpEngine
{
    private const decimal Speed = 100;
    public AlphaJumpEngine()
    {
    }

    public Fuel FuelConsumptionPerOneUnit { get; } = new Fuel(100);

    public decimal MaxLengthChanel { get; } = 500;

    public Fuel CountFuelConsumption(int environmentSize)
    {
        return new Fuel(environmentSize * FuelConsumptionPerOneUnit.FuelValue);
    }

    public decimal CountTime(decimal pathLength)
    {
        return pathLength / Speed;
    }
}