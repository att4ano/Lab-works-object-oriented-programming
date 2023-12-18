using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserIterators;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers;

public interface IParserArgumentHandler<T>
{
    ResultCommandBuild Handle(StringArgumentsIterator iterator, T builder);
}