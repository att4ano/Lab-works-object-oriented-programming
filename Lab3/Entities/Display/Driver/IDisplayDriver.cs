using System.Drawing;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Display.Driver;

public interface IDisplayDriver
{
    public Color Color { get; set; }
    public IMessage Message { get; set; }
}