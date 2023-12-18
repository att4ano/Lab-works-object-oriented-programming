using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.ProcessorCooler.Builder;

public class ProcessorCoolerBuilder
{
    private string? _name;
    private Dimensions? _dimensions;
    private IList<string> _listSupportedSocket;
    private int _maximumDissipatedMassOfHeat;

    public ProcessorCoolerBuilder()
    {
        _listSupportedSocket = new List<string>();
    }

    public ProcessorCoolerBuilder WithName(string name)
    {
        _name = name;
        return this;
    }

    public ProcessorCoolerBuilder WithDimension(Dimensions dimension)
    {
        _dimensions = dimension;
        return this;
    }

    public ProcessorCoolerBuilder WithSupportedSocket(string socketName)
    {
        _listSupportedSocket.Add(socketName);
        return this;
    }

    public ProcessorCoolerBuilder WithMaximumDissipatedMassOfHeat(int maximumDissipatedMassOfHeat)
    {
        _maximumDissipatedMassOfHeat = maximumDissipatedMassOfHeat;
        return this;
    }

    public IProcessorCooler Build()
    {
        if (_dimensions is not null && _name is not null)
        {
            return new ProcessorCooler(
                _name,
                _dimensions,
                _listSupportedSocket,
                _maximumDissipatedMassOfHeat);
        }

        if (_dimensions is null)
        {
            throw new ArgumentNullException(nameof(_dimensions), "cannot be null");
        }
        else
        {
            throw new ArgumentNullException(nameof(_name), "cannot be null");
        }
    }
}
