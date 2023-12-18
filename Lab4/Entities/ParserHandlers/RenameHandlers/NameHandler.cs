using Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserIterators;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers.RenameHandlers;

public class NameHandler : IParserArgumentHandler<RenameCommandBuilder>
{
    public ResultCommandBuild Handle(StringArgumentsIterator iterator, RenameCommandBuilder builder)
    {
        builder.WithNewFileName(iterator.Current());
        return new ResultCommandBuild.Success(builder);
    }
}