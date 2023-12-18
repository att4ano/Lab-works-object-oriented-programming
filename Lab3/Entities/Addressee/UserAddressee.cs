using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Users;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressee;

public class UserAddressee : IAddressee
{
    private readonly IUser _user;

    public UserAddressee(IUser user)
    {
        _user = user;
    }

    public void DirectMessage(IMessage message)
    {
        _user.ReceiveMessage(message);
    }
}