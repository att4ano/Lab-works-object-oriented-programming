using Itmo.ObjectOrientedProgramming.Lab4.Entities.Command.Builder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserIterators;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers.ShowHandlers;

public class ShowModeHandler : IParserArgumentHandler<FileShowCommandBuilder>
{
    public ResultCommandBuild Handle(StringArgumentsIterator iterator, FileShowCommandBuilder builder)
    {
        if (iterator.Current() == "console")
        {
            builder.WithShowMode(iterator.Current());
            return new ResultCommandBuild.Success(builder);
        }

        return new ResultCommandBuild.Failure();
    }
}