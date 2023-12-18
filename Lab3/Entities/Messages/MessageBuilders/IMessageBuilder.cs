namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages.MessageBuilders;

public interface IMessageBuilder
{
    IMessageBuilder WithContentBody(string contentBody);

    IMessageBuilder WithPriority(int priority);

    IMessage Build();
}

public interface ITitleSelector
{
    IMessageBuilder WithTitle(string title);
}