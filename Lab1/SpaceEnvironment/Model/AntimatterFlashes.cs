using System;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceEnvironment.Model.ObstacleInterfaces;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Deflector;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Ship.ShipInterfaces;
using Itmo.ObjectOrientedProgramming.Lab1.TravelServices.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.SpaceEnvironment.Model;

public class AntimatterFlashes : ISpaceNebulaeObstacles, IDamageToCrew
{
    public AntimatterFlashes(int amount)
    {
        Amount = amount;
    }

    public int Amount { get; private set; }

    public ShipStatus MakeDamageCrew(IBaseShip? ship)
    {
        if (ship is not null)
        {
            if (ship is IBaseShipWithDeflector shipWithDeflector)
            {
                if (shipWithDeflector.Deflector is IPhotonicUpgrade deflectorPhotonicUpgrade)
                {
                    if (deflectorPhotonicUpgrade.AntiMatterFlashes >= Amount)
                    {
                        deflectorPhotonicUpgrade.Reflect(Amount);
                        return new ShipStatus(true, true);
                    }
                    else
                    {
                        return new ShipStatus(false, true);
                    }
                }
                else
                {
                    return new ShipStatus(false, true);
                }
            }
            else
            {
                return new ShipStatus(false, true);
            }
        }
        else
        {
            throw new ArgumentNullException(nameof(ship), "cannot be null");
        }
    }
}
