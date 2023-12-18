using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Messenger;

public interface IMessenger
{
    public void ReceiveMessage(IMessage message);
    void PrintMessage();
}