using System.Collections.Generic;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserIterators;

public class StringArgumentsIterator
{
    private int _currentPosition;

    public StringArgumentsIterator(string arguments)
    {
        Arguments = arguments.Split(' ').ToList();
    }

    public StringArgumentsIterator(IList<string> arguments)
    {
        Arguments = arguments;
    }

    public IList<string> Arguments { get; }

    public void First()
    {
        _currentPosition = 0;
    }

    public string Current()
    {
        return Arguments[_currentPosition];
    }

    public void GetNext()
    {
        ++_currentPosition;
    }
}