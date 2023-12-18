using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceEnvironment.Entity;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Ship.ShipInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.TravelServices.Services;

public class CompareTwoRoutesService
{
    public CompareTwoRoutesService(
        IBaseShip? firstShip,
        IBaseShip? secondShip,
        IReadOnlyCollection<BaseEnvironment>? route)
    {
        if (firstShip is not null && secondShip is not null)
        {
            FirstShip = firstShip;
            SecondShip = secondShip;
            Environments = route;
        }
        else
        {
            if (firstShip is null)
            {
                throw new ArgumentNullException(nameof(firstShip), "cannot be null");
            }
            else if (secondShip is null)
            {
                throw new ArgumentNullException(nameof(secondShip), "cannot be null");
            }
            else
            {
                throw new ArgumentNullException(nameof(route), "cannot be null");
            }
        }
    }

    public IBaseShip? FirstShip { get; private set; }
    public IBaseShip? SecondShip { get; private set; }
    public IReadOnlyCollection<BaseEnvironment>? Environments { get; private set; }

    public IBaseShip? FindBestShip()
    {
        var firstRouteService = new Route(FirstShip, Environments);
        var secondRouteService = new Route(SecondShip, Environments);
        firstRouteService.PassRoute();
        secondRouteService.PassRoute();
        if (firstRouteService.RouteShipStatus.IsShipRunning() && !firstRouteService.IsShipLost &&
            secondRouteService.RouteShipStatus.IsShipRunning() && !secondRouteService.IsShipLost)
        {
            if (firstRouteService.CompleteTime < secondRouteService.CompleteTime)
            {
                return firstRouteService.Ship;
            }
            else if (firstRouteService.CompleteTime > secondRouteService.CompleteTime)
            {
                return secondRouteService.Ship;
            }
            else
            {
                if (firstRouteService.MoneyForFuel < secondRouteService.MoneyForFuel)
                {
                    return firstRouteService.Ship;
                }
                else if (firstRouteService.CompleteTime > secondRouteService.CompleteTime)
                {
                    return secondRouteService.Ship;
                }
                else
                {
                    return firstRouteService.Ship;
                }
            }
        }
        else
        {
            if (!(secondRouteService.RouteShipStatus.IsShipRunning() && !secondRouteService.IsShipLost))
            {
                return firstRouteService.Ship;
            }
            else if (!(firstRouteService.RouteShipStatus.IsShipRunning() && !firstRouteService.IsShipLost))
            {
                return secondRouteService.Ship;
            }
            else
            {
                return null;
            }
        }
    }
}