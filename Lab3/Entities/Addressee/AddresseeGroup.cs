﻿using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressee;

public class AddresseeGroup : IAddressee
{
    private readonly IEnumerable<IAddressee> _addressees;

    public AddresseeGroup(IEnumerable<IAddressee> addressees)
    {
        _addressees = addressees;
    }

    public void DirectMessage(IMessage message)
    {
        foreach (IAddressee addressee in _addressees)
        {
            addressee.DirectMessage(message);
        }
    }
}