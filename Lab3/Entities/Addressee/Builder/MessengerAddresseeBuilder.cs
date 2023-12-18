using System;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messenger;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressee.Builder;

public class MessengerAddresseeBuilder : IAddresseeBuilder
{
    private IMessenger? _messenger;

    public MessengerAddresseeBuilder WithMessenger(IMessenger messenger)
    {
        _messenger = messenger;
        return this;
    }

    public IAddressee Build()
    {
        return new MessengerAddressee(
            _messenger ?? throw new ArgumentNullException(nameof(_messenger), "cannot be null"));
    }
}