using Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserIterators;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers.CopyHandlers;

public class CopyCommandHandler : BaseParserHandler
{
    private readonly IParserArgumentHandler<CopyCommandBuilder> _nextHandler;

    public CopyCommandHandler(IParserArgumentHandler<CopyCommandBuilder> nextHandler)
    {
        _nextHandler = nextHandler;
    }

    public override ResultCommandBuild Handle(StringArgumentsIterator iterator)
    {
        if (iterator.Current() != "copy")
        {
            return base.Handle(iterator);
        }

        var copyCommandBuilder = new CopyCommandBuilder();
        iterator.GetNext();
        return _nextHandler.Handle(iterator, copyCommandBuilder);
    }
}