using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.BIOS;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Processor;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.RAM;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.WifiAdapter;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.MotherBoard.Builder;

public class MotherBoardBuilder
{
    private string? _name;
    private Chipset? _motherBoardChipset;
    private Socket? _processorSocket;
    private Ddr? _ddrStandart;
    private IBios? _bios;
    private int _amountRamSlots;
    private string? _formFactor;
    private IList<PcieSlots>? _pciESlots;
    private IList<SataSlots>? _sataSlots;

    public MotherBoardBuilder WithName(string name)
    {
        _name = name;
        return this;
    }

    public MotherBoardBuilder WithChipset(Chipset chipset)
    {
        _motherBoardChipset = chipset;
        return this;
    }

    public MotherBoardBuilder WithSocket(Socket socket)
    {
        _processorSocket = socket;
        return this;
    }

    public MotherBoardBuilder WithDdrStandart(Ddr ddr)
    {
        _ddrStandart = ddr;
        return this;
    }

    public MotherBoardBuilder WithBios(IBios bios)
    {
        _bios = bios;
        return this;
    }

    public MotherBoardBuilder WithAmountRamSlots(int amountRamSlots)
    {
        _amountRamSlots = amountRamSlots;
        return this;
    }

    public MotherBoardBuilder WithFormFactor(string formFactor)
    {
        _formFactor = formFactor;
        return this;
    }

    public MotherBoardBuilder WithPciESlots(IList<PcieSlots> slots)
    {
        _pciESlots = slots;
        return this;
    }

    public MotherBoardBuilder WithSataSlots(IList<SataSlots> slots)
    {
        _sataSlots = slots;
        return this;
    }

    public IMotherBoard Build()
    {
        if (_name is not null && _motherBoardChipset is not null && _processorSocket is not null &&
            _ddrStandart is not null && _bios is not null && _formFactor is not null && _pciESlots is not null &&
            _sataSlots is not null)
        {
            return new MotherBoard(
                _name,
                _motherBoardChipset,
                _processorSocket,
                _ddrStandart,
                _bios,
                _formFactor,
                _amountRamSlots,
                _pciESlots,
                _sataSlots);
        }

        if (_name is null)
        {
            throw new ArgumentNullException(nameof(_name), "cannot be null");
        }
        else if (_motherBoardChipset is null)
        {
            throw new ArgumentNullException(nameof(_motherBoardChipset), "cannot be null");
        }
        else if (_processorSocket is null)
        {
            throw new ArgumentNullException(nameof(_processorSocket), "cannot be null");
        }
        else if (_ddrStandart is null)
        {
            throw new ArgumentNullException(nameof(_ddrStandart), "cannot be null");
        }
        else if (_bios is null)
        {
            throw new ArgumentNullException(nameof(_bios), "cannot be null");
        }
        else if (_formFactor is null)
        {
            throw new ArgumentNullException(nameof(_formFactor), "cannot be null");
        }
        else if (_pciESlots is null)
        {
            throw new ArgumentNullException(nameof(_pciESlots), "cannot be null");
        }
        else
        {
            throw new ArgumentNullException(nameof(_sataSlots), "cannot be null");
        }
    }
}