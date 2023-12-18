using System.Drawing;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Display;

public interface IDisplay
{
    public void ModifyMessage();

    public void SwitchColor(Color color);

    public void ReceiveMessage(IMessage message);

    public void PrintMessage();
}