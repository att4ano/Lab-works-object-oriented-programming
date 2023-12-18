using Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserIterators;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers.CopyHandlers;

public class CopyDestinationPathHandler : IParserArgumentHandler<CopyCommandBuilder>
{
    public ResultCommandBuild Handle(StringArgumentsIterator iterator, CopyCommandBuilder builder)
    {
        builder.WithDestinationPath(iterator.Current());
        return new ResultCommandBuild.Success(builder);
    }
}