using System;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserIterators;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers.MoveHandlers;

public class MoveSourcePathHandler : IParserArgumentHandler<MoveCommandBuilder>
{
    private IParserArgumentHandler<MoveCommandBuilder>? _nextHandler;

    public IParserArgumentHandler<MoveCommandBuilder> AddNext(IParserArgumentHandler<MoveCommandBuilder> nextHandler)
    {
        _nextHandler = nextHandler;
        return nextHandler;
    }

    public ResultCommandBuild Handle(StringArgumentsIterator iterator, MoveCommandBuilder builder)
    {
        if (_nextHandler is null)
            throw new ArgumentNullException(nameof(_nextHandler), "cannot be null");

        builder.WithSourceFilePath(iterator.Current());
        iterator.GetNext();
        return _nextHandler.Handle(iterator, builder);
    }
}