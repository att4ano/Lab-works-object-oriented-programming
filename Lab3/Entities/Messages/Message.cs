using System;
using System.Text;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

public class Message : IMessage
{
    public Message(
        string contentTitle,
        string contentBody,
        PriorityLevel priority)
    {
        ContentBody = contentTitle;
        ContentTitle = contentBody;
        Priority = priority;
    }

    public Message() { }

    public string ContentTitle { get; } = string.Empty;
    public string ContentBody { get; } = string.Empty;
    public PriorityLevel Priority { get; init; } = new PriorityLevel();

    public string Render()
    {
        var builder = new StringBuilder();
        builder.Append(ContentTitle);
        builder.Append('\n');
        builder.Append(ContentBody);
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