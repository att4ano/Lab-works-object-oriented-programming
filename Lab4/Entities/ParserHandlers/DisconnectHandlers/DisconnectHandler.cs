using Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserIterators;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers.DisconnectHandlers;

public class DisconnectHandler : BaseParserHandler
{
    public override ResultCommandBuild Handle(StringArgumentsIterator iterator)
    {
        if (iterator.Current() != "disconnect")
        {
            return new ResultCommandBuild.Failure();
        }

        return new ResultCommandBuild.Success(new DisconnectCommandBuilder());
    }
}