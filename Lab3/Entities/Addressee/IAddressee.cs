using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressee;

public interface IAddressee
{
    void DirectMessage(IMessage message);
}