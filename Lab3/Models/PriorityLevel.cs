using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models;

public record PriorityLevel
{
    public PriorityLevel() { }

    public PriorityLevel(int priorityPoints)
    {
        if (priorityPoints <= 0)
        {
            throw new ArgumentException("cannot be negative number ", nameof(priorityPoints));
        }

        PriorityPoints = priorityPoints;
    }

    public int PriorityPoints { get; init; }
}