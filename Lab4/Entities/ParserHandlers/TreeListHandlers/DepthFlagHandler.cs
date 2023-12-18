using System;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserIterators;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers.TreeListHandlers;

public class DepthFlagHandler : IParserArgumentHandler<TreeShowCommandBuilder>
{
    private IParserArgumentHandler<TreeShowCommandBuilder>? _nextHandler;

    public IParserArgumentHandler<TreeShowCommandBuilder> AddNext(
        IParserArgumentHandler<TreeShowCommandBuilder> nextHandler)
    {
        _nextHandler = nextHandler;
        return nextHandler;
    }

    public ResultCommandBuild Handle(StringArgumentsIterator iterator, TreeShowCommandBuilder builder)
    {
        if (_nextHandler is null)
            throw new ArgumentNullException(nameof(_nextHandler), "cannot be null");

        if (iterator.Current() != "-d")
        {
            return new ResultCommandBuild.Failure();
        }

        iterator.GetNext();
        return _nextHandler.Handle(iterator, builder);
    }
}