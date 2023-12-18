using System;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Display.Driver;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Display.Builder;

public class DisplayBuilder
{
    private DisplayDriver? _driver;

    public DisplayBuilder WithDriver(DisplayDriver driver)
    {
        _driver = driver;
        return this;
    }

    public IDisplay Builder()
    {
        return new Display(
            _driver ?? throw new ArgumentNullException(nameof(_driver), "cannot be null"));
    }
}