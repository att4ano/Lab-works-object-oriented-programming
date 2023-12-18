using System;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserIterators;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers.ShowHandlers;

public class ShowPathHandler : IParserArgumentHandler<FileShowCommandBuilder>
{
    private IParserArgumentHandler<FileShowCommandBuilder>? _nextHandler;

    public IParserArgumentHandler<FileShowCommandBuilder> AddNext(IParserArgumentHandler<FileShowCommandBuilder> nextHandler)
    {
        _nextHandler = nextHandler;
        return nextHandler;
    }

    public ResultCommandBuild Handle(StringArgumentsIterator iterator, FileShowCommandBuilder builder)
    {
        if (_nextHandler is null)
            throw new ArgumentNullException(nameof(_nextHandler), "cannot be null");

        builder.WithPath(iterator.Current());
        iterator.GetNext();
        return _nextHandler.Handle(iterator, builder);
    }
}