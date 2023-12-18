using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Models.Points;

public class Fuel
{
    public Fuel(decimal fuelValue)
    {
        if (fuelValue < 0)
        {
            throw new ArgumentException("Fuel value cannot be negative");
        }

        FuelValue = fuelValue;
    }

    public Fuel()
    {
    }

    public decimal FuelValue { get; private set; } = 0;

    public static Fuel operator +(Fuel? left, Fuel? right)
    {
        if (left is not null && right is not null)
        {
            return new Fuel(left.FuelValue + right.FuelValue);
        }
        else
        {
            if (left is null)
            {
                throw new ArgumentNullException(nameof(left), "cannot be null");
            }
            else
            {
                throw new ArgumentNullException(nameof(right), "cannot be null");
            }
        }
    }

    public static Fuel Substract(Fuel? left, Fuel? right)
    {
        if (left is not null && right is not null)
        {
            return new Fuel(left.FuelValue - right.FuelValue);
        }
        else
        {
            if (left is null)
            {
                throw new ArgumentNullException(nameof(left));
            }
            else
            {
                throw new ArgumentNullException(nameof(right));
            }
        }
    }

    public static Fuel Add(Fuel? left, Fuel? right)
    {
        if (left is not null && right is not null)
        {
            return new Fuel(left.FuelValue + right.FuelValue);
        }
        else
        {
            if (left is null)
            {
                throw new ArgumentNullException(nameof(left), "cannot be null");
            }
            else
            {
                throw new ArgumentNullException(nameof(right), "cannot be null");
            }
        }
    }
}