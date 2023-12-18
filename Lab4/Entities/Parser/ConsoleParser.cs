using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.Command;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers.ConnectHandlers;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers.CopyHandlers;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers.DeleteHandlers;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers.DisconnectHandlers;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers.GotoHandlers;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers.MoveHandlers;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers.RenameHandlers;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers.ShowHandlers;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserHandlers.TreeListHandlers;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.ParserIterators;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.Parser;

public class ConsoleParser
{
    private readonly CopySourcePathHandler _copySourcePathHandler;
    private readonly CopyDestinationPathHandler _destinationCopyPathHandler;
    private readonly CopyCommandHandler _copyCommandHandler;
    private readonly ShowPathHandler _showSourcePathHandler;
    private readonly ShowFlagHandler _showFlagHandler;
    private readonly ShowModeHandler _showModeHandler;
    private readonly ShowCommandHandler _showCommandHandler;
    private readonly MoveSourcePathHandler _moveSourcePathHandler;
    private readonly MoveDestinationPathHandler _moveDestinationPathHandler;
    private readonly MoveCommandHandler _moveCommandHandler;
    private readonly DeleteSourcePathHandler _deleteSourcePathHandler;
    private readonly FileDeleteHandler _fileDeleteHandler;
    private readonly NameHandler _nameHandler;
    private readonly RenamePathHandler _renamePathHandler;
    private readonly RenameCommandHandler _renameCommandHandler;
    private readonly DepthHandler _treeListDepthHandler;
    private readonly DepthFlagHandler _treeListDepthFlagHandler;
    private readonly ListHandler _listHandler;
    private readonly GotoPathHandler _gotoPathHandler;
    private readonly TreeGotoHandler _treeGotoHandler;
    private readonly TreeParserHandler _treeHandler;
    private readonly ConnectModePath _connectModePath;
    private readonly ConnectPathHandler _connectPathHandler;
    private readonly ConnectCommandHandler _connectHandler;
    private readonly DisconnectHandler _disconnectHandler;
    private readonly FileHandler _fileHandler;

    public ConsoleParser()
    {
        _copySourcePathHandler = new CopySourcePathHandler();
        _destinationCopyPathHandler = new CopyDestinationPathHandler();
        _copySourcePathHandler.AddNext(_destinationCopyPathHandler);
        _copyCommandHandler = new CopyCommandHandler(_copySourcePathHandler);
        _showSourcePathHandler = new ShowPathHandler();
        _showFlagHandler = new ShowFlagHandler();
        _showModeHandler = new ShowModeHandler();
        _showFlagHandler.AddNext(_showModeHandler);
        _showSourcePathHandler.AddNext(_showFlagHandler);
        _showCommandHandler = new ShowCommandHandler(_showSourcePathHandler);
        _copyCommandHandler.SetParserHandler(_showCommandHandler);
        _moveSourcePathHandler = new MoveSourcePathHandler();
        _moveDestinationPathHandler = new MoveDestinationPathHandler();
        _moveSourcePathHandler.AddNext(_moveDestinationPathHandler);
        _moveCommandHandler = new MoveCommandHandler(_moveSourcePathHandler);
        _showCommandHandler.SetParserHandler(_moveCommandHandler);
        _deleteSourcePathHandler = new DeleteSourcePathHandler();
        _fileDeleteHandler = new FileDeleteHandler(_deleteSourcePathHandler);
        _moveCommandHandler.SetParserHandler(_fileDeleteHandler);
        _nameHandler = new NameHandler();
        _renamePathHandler = new RenamePathHandler();
        _renamePathHandler.AddNext(_nameHandler);
        _renameCommandHandler = new RenameCommandHandler(_renamePathHandler);
        _fileDeleteHandler.SetParserHandler(_renameCommandHandler);
        _fileHandler = new FileHandler(_copyCommandHandler);
        _treeListDepthHandler = new DepthHandler();
        _treeListDepthFlagHandler = new DepthFlagHandler();
        _treeListDepthFlagHandler.AddNext(_treeListDepthHandler);
        _listHandler = new ListHandler(_treeListDepthFlagHandler);
        _gotoPathHandler = new GotoPathHandler();
        _treeGotoHandler = new TreeGotoHandler(_gotoPathHandler);
        _listHandler.SetParserHandler(_treeGotoHandler);
        _treeHandler = new TreeParserHandler(_listHandler);
        _fileHandler.SetParserHandler(_treeHandler);
        _connectModePath = new ConnectModePath();
        _connectPathHandler = new ConnectPathHandler();
        _connectPathHandler.AddNext(_connectModePath);
        _connectHandler = new ConnectCommandHandler(_connectPathHandler);
        _treeHandler.SetParserHandler(_connectHandler);
        _disconnectHandler = new DisconnectHandler();
        _connectHandler.SetParserHandler(_disconnectHandler);
    }

    public ICommand? Parse(IList<string> commandArguments)
    {
        var iterator = new StringArgumentsIterator(commandArguments ?? throw new ArgumentNullException(nameof(commandArguments), "cannot be null"));
        ResultCommandBuild result = _fileHandler.Handle(iterator);
        if (result is ResultCommandBuild.Success success)
        {
            return success.Builder.Build();
        }

        return null;
    }
}