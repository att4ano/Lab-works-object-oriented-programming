using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserIterators;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers;

public abstract class BaseParserHandler
{
    private BaseParserHandler? _nextHandler;

    public BaseParserHandler SetParserHandler(BaseParserHandler parserHandler)
    {
        _nextHandler = parserHandler;
        return parserHandler;
    }

    public virtual ResultCommandBuild Handle(StringArgumentsIterator iterator)
    {
        if (_nextHandler is null)
            return new ResultCommandBuild.Failure();

        return _nextHandler.Handle(iterator);
    }
}