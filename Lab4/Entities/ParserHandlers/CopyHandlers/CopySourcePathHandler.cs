using System;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserIterators;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers.CopyHandlers;

public class CopySourcePathHandler : IParserArgumentHandler<CopyCommandBuilder>
{
    private IParserArgumentHandler<CopyCommandBuilder>? _nextHandler;

    public IParserArgumentHandler<CopyCommandBuilder> AddNext(IParserArgumentHandler<CopyCommandBuilder> nextHandler)
    {
        _nextHandler = nextHandler;
        return nextHandler;
    }

    public ResultCommandBuild Handle(StringArgumentsIterator iterator, CopyCommandBuilder builder)
    {
        if (_nextHandler is null)
            throw new ArgumentNullException(nameof(_nextHandler), "cannot be null");

        builder.WithSourceFilePath(iterator.Current());
        iterator.GetNext();
        return _nextHandler.Handle(iterator, builder);
    }
}