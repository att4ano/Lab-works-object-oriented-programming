using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Models.Points;

public class HealthPoints
{
    public HealthPoints(decimal healthValue)
    {
        HealthValue = healthValue < 0 ? 0 : healthValue;
    }

    public decimal HealthValue { get; private set; }

    public static bool operator <(HealthPoints left, HealthPoints right)
    {
        return left.HealthValue < right.HealthValue;
    }

    public static bool operator >(HealthPoints left, HealthPoints right)
    {
        return left.HealthValue > right.HealthValue;
    }

    public static bool operator <(HealthPoints left, decimal right)
    {
        return left.HealthValue < right;
    }

    public static bool operator >(HealthPoints left, decimal right)
    {
        return left.HealthValue > right;
    }

    public static HealthPoints operator -(HealthPoints? left, HealthPoints? right)
    {
        if (left is not null && right is not null)
        {
            return new HealthPoints(left.HealthValue - right.HealthValue);
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

    public static decimal operator -(decimal left, HealthPoints? right)
    {
        if (right is not null)
        {
            return left - right.HealthValue;
        }
        else
        {
            throw new ArgumentNullException(nameof(right), "cannot be null");
        }
    }

    public static bool Compare(HealthPoints? left, HealthPoints? right)
    {
        if (left is not null && right is not null)
        {
            return left.HealthValue < right.HealthValue;
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

    public static HealthPoints Subtract(HealthPoints left, HealthPoints right)
    {
        return new HealthPoints(left.HealthValue - right.HealthValue);
    }
}