using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models;

public record UserMessages
{
    public UserMessages()
    {
        Messages = new Dictionary<IMessage, bool>();
    }

    public Dictionary<IMessage, bool> Messages { get; }

    public bool IsRead(IMessage message)
    {
        if (!Messages.ContainsKey(message))
        {
            throw new ArgumentException("This message does not exist");
        }

        return Messages[message];
    }
}