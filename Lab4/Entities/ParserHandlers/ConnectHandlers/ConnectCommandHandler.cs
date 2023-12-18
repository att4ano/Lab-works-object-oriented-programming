using Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserIterators;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers.ConnectHandlers;

public class ConnectCommandHandler : BaseParserHandler
{
    private readonly IParserArgumentHandler<ConnectCommandBuilder> _nextHandler;

    public ConnectCommandHandler(IParserArgumentHandler<ConnectCommandBuilder> nextHandler)
    {
        _nextHandler = nextHandler;
    }

    public override ResultCommandBuild Handle(StringArgumentsIterator iterator)
    {
        if (iterator.Current() != "connect")
        {
            return base.Handle(iterator);
        }

        var builder = new ConnectCommandBuilder();
        iterator.GetNext();
        return _nextHandler.Handle(iterator, builder);
    }
}