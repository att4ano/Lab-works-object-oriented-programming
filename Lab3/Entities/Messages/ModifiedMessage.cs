using System;
using System.Drawing;
using System.Text;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

public class ModifiedMessage : IMessage
{
    private readonly Color _color;

    public ModifiedMessage(
        IMessage message,
        Color color)
    {
        _color = color;
        if (message is null)
        {
            throw new ArgumentNullException(nameof(message), "cannot be null");
        }

        ContentTitle = message.ContentTitle;
        ContentBody = message.ContentBody;
        Priority = message.Priority;
    }

    public string ContentTitle { get; }
    public string ContentBody { get; }
    public PriorityLevel Priority { get; }

    public string Render()
    {
        var builder = new StringBuilder();
        builder
            .Append(Crayon.Output.Rgb(_color.R, _color.G, _color.B).Text(ContentTitle))
            .Append('\n')
            .Append(Crayon.Output.Rgb(_color.R, _color.G, _color.B).Text(ContentBody));
        return builder.ToString();
    }

    public bool Equals(IMessage? other)
    {
        if (other is null)
        {
            return false;
        }

        return (ContentTitle == other.ContentTitle) && (ContentBody == other.ContentBody);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(ContentTitle, ContentBody);
    }
}