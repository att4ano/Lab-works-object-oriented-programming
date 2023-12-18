using System;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.MessageLogger;

public class ConsoleLogger : ILogger
{
    private int _messageAmount;
    public ConsoleLogger() { }

    public void MakeLog(IMessage message)
    {
        ++_messageAmount;
        Console.WriteLine($"id {_messageAmount}: " + message.Render());
        Console.WriteLine('\n');
    }
}