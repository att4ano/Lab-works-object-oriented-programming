using System.IO;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.MessageLogger;

public class FileLogger : ILogger
{
    private readonly string _logPath = "Logs.txt";
    private int _messageAmount;

    public FileLogger() { }

    public void MakeLog(IMessage message)
    {
        ++_messageAmount;
        File.AppendAllText(_logPath, $"id {_messageAmount}: " + message.Render());
    }
}