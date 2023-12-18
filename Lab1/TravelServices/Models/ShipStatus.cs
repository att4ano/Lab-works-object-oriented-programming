namespace Itmo.ObjectOrientedProgramming.Lab1.TravelServices.Models;

public record ShipStatus
{
    public ShipStatus()
    {
        IsShipAlive = true;
        IsCrewAlive = true;
    }

    public ShipStatus(bool isCrewAlive, bool isShipAlive)
    {
        IsShipAlive = isShipAlive;
        IsCrewAlive = isCrewAlive;
    }

    public bool IsCrewAlive { get; }
    public bool IsShipAlive { get; }

    public bool IsShipRunning()
    {
        return IsCrewAlive && IsShipAlive;
    }
}