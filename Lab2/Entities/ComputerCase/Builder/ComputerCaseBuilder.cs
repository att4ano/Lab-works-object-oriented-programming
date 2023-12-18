using System;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.ComputerCase.Builder;

public class ComputerCaseBuilder
{
    private string? _name;
    private Dimensions? _dimension;
    private Dimensions? _maxVideoCardDimension;
    private string? _motherBoardFormFactor;

    public ComputerCaseBuilder WithName(string name)
    {
        _name = name;
        return this;
    }

    public ComputerCaseBuilder WithDimension(Dimensions dimension)
    {
        _dimension = dimension;
        return this;
    }

    public ComputerCaseBuilder WithMaxVideoCardDimensions(Dimensions maxVideoCardDimensions)
    {
        _maxVideoCardDimension = maxVideoCardDimensions;
        return this;
    }

    public ComputerCaseBuilder WithMotherBoardFormFactor(string formFactor)
    {
        _motherBoardFormFactor = formFactor;
        return this;
    }

    public IComputerCase Build()
    {
        if (_name is not null && _dimension is not null && _maxVideoCardDimension is not null &&
            _motherBoardFormFactor is not null)
        {
            return new ComputerCase(
                _name,
                _dimension,
                _maxVideoCardDimension,
                _motherBoardFormFactor);
        }

        if (_name is null)
        {
            throw new ArgumentNullException(nameof(_name), "cannot be null");
        }
        else if (_dimension is null)
        {
            throw new ArgumentNullException(nameof(_dimension), "cannot be null");
        }
        else if (_maxVideoCardDimension is null)
        {
            throw new ArgumentNullException(nameof(_maxVideoCardDimension), "cannot be null");
        }
        else
        {
            throw new ArgumentNullException(nameof(_motherBoardFormFactor), "cannot be null");
        }
    }
}