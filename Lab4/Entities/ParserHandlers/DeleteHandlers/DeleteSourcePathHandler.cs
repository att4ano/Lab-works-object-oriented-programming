using Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserIterators;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers.DeleteHandlers;

public class DeleteSourcePathHandler : IParserArgumentHandler<DeleteCommandBuilder>
{
    public ResultCommandBuild Handle(StringArgumentsIterator iterator, DeleteCommandBuilder builder)
    {
        builder.WithFilePath(iterator.Current());
        return new ResultCommandBuild.Success(builder);
    }
}