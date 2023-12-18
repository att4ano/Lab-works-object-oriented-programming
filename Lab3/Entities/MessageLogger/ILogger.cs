using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.MessageLogger;

public interface ILogger
{
    void MakeLog(IMessage message);
}