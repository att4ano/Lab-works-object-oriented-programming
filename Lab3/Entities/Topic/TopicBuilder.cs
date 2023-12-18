using System;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressee;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Topic;

public class TopicBuilder
{
    private string? _topicName;
    private IAddressee? _addressee;

    public TopicBuilder WithName(string topicName)
    {
        _topicName = topicName;
        return this;
    }

    public TopicBuilder WithAddressee(IAddressee addressee)
    {
        _addressee = addressee;
        return this;
    }

    public Topic Build()
    {
        return new Topic(
            _topicName ?? throw new ArgumentNullException(nameof(_topicName), "cannot be null"),
            _addressee ?? throw new ArgumentNullException(nameof(_addressee), "cannot be null"));
    }
}