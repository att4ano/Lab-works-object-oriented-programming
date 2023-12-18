using System;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserIterators;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers.RenameHandlers;

public class RenamePathHandler : IParserArgumentHandler<RenameCommandBuilder>
{
    private IParserArgumentHandler<RenameCommandBuilder>? _nextHandler;

    public IParserArgumentHandler<RenameCommandBuilder> AddNext(IParserArgumentHandler<RenameCommandBuilder> nextHandler)
    {
        _nextHandler = nextHandler;
        return nextHandler;
    }

    public ResultCommandBuild Handle(StringArgumentsIterator iterator, RenameCommandBuilder builder)
    {
        if (_nextHandler is null)
            throw new ArgumentNullException(nameof(_nextHandler), "cannot be null");

        builder.WithSourceFilePath(iterator.Current());
        iterator.GetNext();
        return _nextHandler.Handle(iterator, builder);
    }
}