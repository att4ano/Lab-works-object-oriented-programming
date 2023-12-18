using Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserIterators;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers.ShowHandlers;

public class ShowCommandHandler : BaseParserHandler
{
    private readonly IParserArgumentHandler<FileShowCommandBuilder> _nextHandler;

    public ShowCommandHandler(IParserArgumentHandler<FileShowCommandBuilder> nextHandler)
    {
        _nextHandler = nextHandler;
    }

    public override ResultCommandBuild Handle(StringArgumentsIterator iterator)
    {
        if (iterator.Current() != "show")
        {
            return base.Handle(iterator);
        }

        var showCommandBuilder = new FileShowCommandBuilder();
        iterator.GetNext();
        return _nextHandler.Handle(iterator, showCommandBuilder);
    }
}