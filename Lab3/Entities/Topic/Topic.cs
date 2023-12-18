using Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressee;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Topic;

public class Topic
{
    private readonly IAddressee _addressee;

    public Topic(
        string topicName,
        IAddressee addressee)
    {
        TopicName = topicName;
        _addressee = addressee;
    }

    public string TopicName { get; }

    public void DirectMessage(IMessage message)
    {
        _addressee.DirectMessage(message);
    }
}
