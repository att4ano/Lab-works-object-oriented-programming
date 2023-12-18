using Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserIterators;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers.RenameHandlers;

public class RenameCommandHandler : BaseParserHandler
{
    private readonly IParserArgumentHandler<RenameCommandBuilder> _nextHandler;

    public RenameCommandHandler(IParserArgumentHandler<RenameCommandBuilder> nextHandler)
    {
        _nextHandler = nextHandler;
    }

    public override ResultCommandBuild Handle(StringArgumentsIterator iterator)
    {
        if (iterator.Current() != "rename")
        {
            return base.Handle(iterator);
        }

        var renameCommandBuilder = new RenameCommandBuilder();
        iterator.GetNext();
        return _nextHandler.Handle(iterator, renameCommandBuilder);
    }
}