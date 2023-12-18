using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Models.Points;

namespace Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Engine.EngineInterfaces;

public class ImpulseEngineC : IImpulseEngine
{
    private const decimal Speed = 50;

    public ImpulseEngineC()
    {
        FuelConsumptionPerOneUnit = new Fuel(15);
    }

    public Fuel FuelConsumptionPerOneUnit { get; }

    public Fuel CountFuelConsumption(int environmentSize)
    {
        return new Fuel(environmentSize * FuelConsumptionPerOneUnit.FuelValue);
    }

    public decimal CountTime(decimal pathLength)
    {
        return pathLength / Speed;
    }
}