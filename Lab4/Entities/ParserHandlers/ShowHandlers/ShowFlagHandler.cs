using System;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserIterators;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers.ShowHandlers;

public class ShowFlagHandler : IParserArgumentHandler<FileShowCommandBuilder>
{
    private IParserArgumentHandler<FileShowCommandBuilder>? _nextParserArgumentHandler;

    public IParserArgumentHandler<FileShowCommandBuilder> AddNext(
        IParserArgumentHandler<FileShowCommandBuilder> nextHandler)
    {
        _nextParserArgumentHandler = nextHandler;
        return nextHandler;
    }

    public ResultCommandBuild Handle(StringArgumentsIterator iterator, FileShowCommandBuilder builder)
    {
        if (_nextParserArgumentHandler is null)
        {
            throw new ArgumentNullException(nameof(_nextParserArgumentHandler), "cannot be null");
        }

        if (iterator.Current() == "-m")
        {
            iterator.GetNext();
            return _nextParserArgumentHandler.Handle(iterator, builder);
        }

        return new ResultCommandBuild.Failure();
    }
}