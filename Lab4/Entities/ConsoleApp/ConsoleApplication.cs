using System;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.Command;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystem;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.Parser;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.WriterService;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.ConsoleApp;

public class ConsoleApplication
{
    private IWriter _outputService;

    private ContextFileSystem _context;
    private ConsoleParser _parser;

    public ConsoleApplication(IWriter outputService, ContextFileSystem context, ConsoleParser parser)
    {
        _outputService = outputService;
        _context = context;
        _parser = parser;
    }

    public void Execute(string arguments)
    {
        ICommand? command = _parser.Parse(arguments.Split());
        if (command is not null)
        {
            _outputService.OutputExecuteResult(command.Execute(_context));
        }
        else
        {
            Console.WriteLine("Unknown command");
        }
    }
}