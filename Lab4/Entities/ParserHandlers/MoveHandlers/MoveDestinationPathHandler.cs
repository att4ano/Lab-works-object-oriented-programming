using Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserIterators;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers.MoveHandlers;

public class MoveDestinationPathHandler : IParserArgumentHandler<MoveCommandBuilder>
{
    public ResultCommandBuild Handle(StringArgumentsIterator iterator, MoveCommandBuilder builder)
    {
        builder.WithDestinationPath(iterator.Current());
        return new ResultCommandBuild.Success(builder);
    }
}