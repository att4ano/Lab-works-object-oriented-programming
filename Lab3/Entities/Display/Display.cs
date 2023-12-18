using System;
using System.Drawing;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Display.Driver;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Display;

public class Display : IDisplay
{
    private readonly IDisplayDriver _driver;

    public Display(IDisplayDriver driver)
    {
        _driver = driver;
    }

    public void SwitchColor(Color color)
    {
        _driver.Color = color;
    }

    public void ReceiveMessage(IMessage message)
    {
        _driver.Message = message;
    }

    public void ModifyMessage()
    {
        _driver.Message = new ModifiedMessage(_driver.Message, _driver.Color);
    }

    public void PrintMessage()
    {
        Console.WriteLine(_driver.Message.Render());
        Console.WriteLine('\n');
    }
}