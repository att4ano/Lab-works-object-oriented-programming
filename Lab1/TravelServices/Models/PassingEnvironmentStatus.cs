namespace Itmo.ObjectOrientedProgramming.Lab1.TravelServices.Models;

public record PassingEnvironmentStatus
{
    public PassingEnvironmentStatus()
    {
        Status = new ShipStatus();
        ConsumptionStatus = new RouteConsumptionStatus();
        IsShipLost = false;
    }

    public PassingEnvironmentStatus(ShipStatus shipStatus,  RouteConsumptionStatus consumptionStatus, bool isShipLost)
    {
        Status = shipStatus;
        ConsumptionStatus = consumptionStatus;
        IsShipLost = isShipLost;
    }

    public ShipStatus Status { get; }
    public RouteConsumptionStatus ConsumptionStatus { get; }
    public bool IsShipLost { get; }
}