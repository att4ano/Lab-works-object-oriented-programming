using Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserIterators;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers.TreeListHandlers;

public class DepthHandler : IParserArgumentHandler<TreeShowCommandBuilder>
{
    public ResultCommandBuild Handle(StringArgumentsIterator iterator, TreeShowCommandBuilder builder)
    {
        if (!(int.TryParse(iterator.Current(), out int depth) && depth > 0))
        {
            return new ResultCommandBuild.Failure();
        }

        builder.WithDepth(depth);
        return new ResultCommandBuild.Success(builder);
    }
}