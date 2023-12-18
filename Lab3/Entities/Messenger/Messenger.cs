using System;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Messenger;

public class Messenger : IMessenger
{
    private IMessage? _message;
    public void ReceiveMessage(IMessage message)
    {
        _message = message;
    }

    public void PrintMessage()
    {
        Console.WriteLine("Messenger: " + (_message ?? throw new ArgumentNullException()).Render());
    }
}