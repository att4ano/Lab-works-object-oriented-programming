using System;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Users;

public class User : IUser
{
    public User(string userName)
    {
        Name = userName;
    }

    public string Name { get; }
    public UserMessages ReceivedMessage { get; } = new UserMessages();

    public void ReceiveMessage(IMessage message)
    {
        ReceivedMessage.Messages.Add(message, false);
    }

    public void MarkAsRead(IMessage message)
    {
        if (ReceivedMessage.Messages[message])
        {
            throw new ArgumentException("Message has already read");
        }

        ReceivedMessage.Messages[message] = true;
    }
}