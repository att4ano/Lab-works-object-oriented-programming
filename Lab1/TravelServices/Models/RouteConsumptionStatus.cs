using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Models.Points;

namespace Itmo.ObjectOrientedProgramming.Lab1.TravelServices.Models;

public record RouteConsumptionStatus
{
    public RouteConsumptionStatus()
    {
    }

    public RouteConsumptionStatus(decimal time, Fuel ordinaryFuelConsumption, Fuel gravityFuelConsumption)
    {
        Time = time;
        OrdinaryFuelConsumption = ordinaryFuelConsumption;
        GravityFuelConsumption = gravityFuelConsumption;
    }

    public decimal Time { get; } = 0;
    public Fuel OrdinaryFuelConsumption { get; } = new Fuel();
    public Fuel GravityFuelConsumption { get; } = new Fuel();
}