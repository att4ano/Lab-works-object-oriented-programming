using Itmo.ObjectOrientedProgramming.Lab3.Entities.Display;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressee;

public class DisplayAddressee : IAddressee
{
    private readonly IDisplay _display;

    public DisplayAddressee(IDisplay display)
    {
        _display = display;
    }

    public void DirectMessage(IMessage message)
    {
        _display.ReceiveMessage(message);
    }
}