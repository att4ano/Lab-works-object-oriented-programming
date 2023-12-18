using Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserIterators;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers.GotoHandlers;

public class GotoPathHandler : IParserArgumentHandler<GotoCommandBuilder>
{
    public ResultCommandBuild Handle(StringArgumentsIterator iterator, GotoCommandBuilder builder)
    {
        builder.WithDestinationBuilder(iterator.Current());
        iterator.GetNext();
        return new ResultCommandBuild.Success(builder);
    }
}