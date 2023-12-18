using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Models.Points;

namespace Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Engine.EngineInterfaces;

public interface IEngine
{
    public Fuel FuelConsumptionPerOneUnit { get; }

    public Fuel CountFuelConsumption(int environmentSize);
    public decimal CountTime(decimal pathLength);
}