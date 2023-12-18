using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserIterators;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers;

public class FileHandler : BaseParserHandler
{
    private readonly BaseParserHandler _nextParserHandler;

    public FileHandler(BaseParserHandler parserHandler)
    {
        _nextParserHandler = parserHandler;
    }

    public override ResultCommandBuild Handle(StringArgumentsIterator iterator)
    {
        if (iterator.Current() == "file")
        {
            iterator.GetNext();
            return _nextParserHandler.Handle(iterator);
        }

        return base.Handle(iterator);
    }
}