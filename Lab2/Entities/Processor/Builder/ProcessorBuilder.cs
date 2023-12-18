using System;
using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Processor.Builder;

public class ProcessorBuilder
{
    private int _coreAmount;
    private int _coreFrequency;
    private Socket? _requiredSocket;
    private IList<int>? _ramFrequency;
    private int _heatDissipation;
    private bool _withVideCore;
    private string? _nameOfProcessor;
    private int _powerConsumption;

    public ProcessorBuilder WithCoreAmount(int coreAmount)
    {
        _coreAmount = coreAmount;
        return this;
    }

    public ProcessorBuilder WIthCoreFrequency(int coreFrequency)
    {
        _coreFrequency = coreFrequency;
        return this;
    }

    public ProcessorBuilder WithRequiredSocket(Socket requiredSocket)
    {
        _requiredSocket = requiredSocket;
        return this;
    }

    public ProcessorBuilder WithRamFrequency(IList<int> ramFrequency)
    {
        _ramFrequency = ramFrequency;
        return this;
    }

    public ProcessorBuilder WithHeatDissipation(int heatDissipation)
    {
        _heatDissipation = heatDissipation;
        return this;
    }

    public ProcessorBuilder WithVideoCore(bool withVideoCore)
    {
        _withVideCore = withVideoCore;
        return this;
    }

    public ProcessorBuilder WithName(string processorName)
    {
        _nameOfProcessor = processorName;
        return this;
    }

    public ProcessorBuilder WithPowerConsumption(int powerConsumption)
    {
        _powerConsumption = powerConsumption;
        return this;
    }

    public IProcessor Build()
    {
        if (_requiredSocket is not null && _nameOfProcessor is not null && _ramFrequency is not null)
        {
            return new Processor(
                _nameOfProcessor,
                _powerConsumption,
                _coreAmount,
                _coreFrequency,
                _requiredSocket,
                _ramFrequency,
                _heatDissipation,
                _withVideCore);
        }

        if (_requiredSocket is null)
        {
            throw new ArgumentNullException(nameof(_withVideCore), "cannot be null");
        }
        else if (_nameOfProcessor is null)
        {
            throw new ArgumentNullException(nameof(_nameOfProcessor), "cannot be null");
        }
        else
        {
            throw new ArgumentNullException(nameof(_ramFrequency), "cannot be null");
        }
    }
}