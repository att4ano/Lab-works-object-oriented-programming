using System;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserIterators;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers.ConnectHandlers;

public class ConnectPathHandler : IParserArgumentHandler<ConnectCommandBuilder>
{
    private IParserArgumentHandler<ConnectCommandBuilder>? _nextPathHandler;

    public IParserArgumentHandler<ConnectCommandBuilder> AddNext(
        IParserArgumentHandler<ConnectCommandBuilder> nextPathHandler)
    {
        _nextPathHandler = nextPathHandler;
        return nextPathHandler;
    }

    public ResultCommandBuild Handle(StringArgumentsIterator iterator, ConnectCommandBuilder builder)
    {
        if (_nextPathHandler is null)
            throw new ArgumentNullException(nameof(_nextPathHandler), "cannot be null");
        builder.WithContextPath(iterator.Current());
        iterator.GetNext();
        return _nextPathHandler.Handle(iterator, builder);
    }
}