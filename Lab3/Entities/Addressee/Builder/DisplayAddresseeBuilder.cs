using System;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Display;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressee.Builder;

public class DisplayAddresseeBuilder : IAddresseeBuilder
{
    private IDisplay? _display;

    public DisplayAddresseeBuilder WithDisplay(IDisplay display)
    {
        _display = display;
        return this;
    }

    public IAddressee Build()
    {
        return new DisplayAddressee(
            _display ?? throw new ArgumentNullException(nameof(_display), "cannot be null"));
    }
}