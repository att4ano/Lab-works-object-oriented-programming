using Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserIterators;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers.ConnectHandlers;

public class ConnectModePath : IParserArgumentHandler<ConnectCommandBuilder>
{
    public ResultCommandBuild Handle(StringArgumentsIterator iterator, ConnectCommandBuilder builder)
    {
        if (iterator.Current() != "local")
        {
            return new ResultCommandBuild.Failure();
        }

        builder.WithModification(iterator.Current());
        return new ResultCommandBuild.Success(builder);
    }
}