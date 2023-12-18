using System;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages.MessageBuilders;

public class MessageBuilder : ITitleSelector, IMessageBuilder
{
    private string? _contentTitle;
    private string? _contentBody;
    private PriorityLevel? _priorityLevel;

    public IMessageBuilder WithTitle(string title)
    {
        _contentTitle = title;
        return this;
    }

    public IMessageBuilder WithContentBody(string contentBody)
    {
        _contentBody = contentBody;
        return this;
    }

    public IMessageBuilder WithPriority(int priority)
    {
        _priorityLevel = new PriorityLevel(priority);
        return this;
    }

    public IMessage Build()
    {
        return new Messages.Message(
            _contentTitle ?? throw new ArgumentNullException(nameof(_contentTitle), "cannot be null"),
            _contentBody ?? throw new ArgumentNullException(nameof(_contentBody), "cannot be null"),
            _priorityLevel ?? throw new ArgumentNullException(nameof(_priorityLevel), "cannot be null"));
    }
}