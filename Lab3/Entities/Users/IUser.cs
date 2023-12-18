using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Users;

public interface IUser
{
    string Name { get; }

    public UserMessages ReceivedMessage { get; }

    public void ReceiveMessage(IMessage message);

    public void MarkAsRead(IMessage message);
}