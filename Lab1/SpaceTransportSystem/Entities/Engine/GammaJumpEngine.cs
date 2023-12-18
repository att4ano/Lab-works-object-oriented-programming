using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Engine.EngineInterfaces;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Models.Points;

namespace Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Engine;

public class GammaJumpEngine : IJumpEngine
{
    private const decimal Speed = 200;

    public GammaJumpEngine()
    {
    }

    public Fuel FuelConsumptionPerOneUnit { get; } = new Fuel(100);

    public decimal MaxLengthChanel { get; } = 1500;

    public Fuel CountFuelConsumption(int environmentSize)
    {
        return new Fuel(FuelConsumptionPerOneUnit.FuelValue * FuelConsumptionPerOneUnit.FuelValue * environmentSize);
    }

    public decimal CountTime(decimal pathLength)
    {
        return pathLength / Speed;
    }
}