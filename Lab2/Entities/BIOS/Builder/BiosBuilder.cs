using System;
using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.BIOS.Builder;

public class BiosBuilder
{
    private string? _name;
    private int _version;
    private string? _biosType;
    private List<string> _listOfSupportedProcessors;

    public BiosBuilder()
    {
        _listOfSupportedProcessors = new List<string>();
    }

    public BiosBuilder WithVersion(int version)
    {
        _version = version;
        return this;
    }

    public BiosBuilder WithBiosType(string biosType)
    {
        _biosType = biosType;
        return this;
    }

    public BiosBuilder WithSupportedProcessor(string supportedProcessor)
    {
        _listOfSupportedProcessors.Add(supportedProcessor);
        return this;
    }

    public BiosBuilder WihName(string name)
    {
        _name = name;
        return this;
    }

    public IBios Build()
    {
        if (_biosType is not null && _name is not null)
        {
            return new Bios(
                _name,
                _version,
                _biosType,
                _listOfSupportedProcessors);
        }

        if (_name is null)
        {
            throw new ArgumentNullException(nameof(_name), "cannot be null");
        }

        throw new ArgumentNullException(nameof(_biosType), "cannot be null");
    }
}