using System.Drawing;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Display.Driver;

public class DisplayDriver : IDisplayDriver
{
    public Color Color { get; set; } = Color.Empty;
    public IMessage Message { get; set; } = new Message();
}