using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.BIOS;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.MotherBoard.Builder;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Processor;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.RAM;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.WifiAdapter;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.MotherBoard;

public class MotherBoard : IMotherBoard
{
    public MotherBoard(
        string nameOfMotherBoard,
        Chipset motherBoardChipset,
        Socket processorSocket,
        Ddr ddrStandart,
        IBios bios,
        string formFactor,
        int amountRamSlots,
        IList<PcieSlots> pciESlots,
        IList<SataSlots> sataSlots)
    {
        Name = nameOfMotherBoard;
        MotherBoardChipset = motherBoardChipset;
        ProcessorSocket = processorSocket;
        DdrStandart = ddrStandart;
        Bios = bios;
        AmountRamSlots = amountRamSlots;
        FormFactor = formFactor;
        PciESlots = pciESlots;
        SataSlots = sataSlots;
    }

    public string Name { get; init; }

    public IList<PcieSlots> PciESlots { get; }
    public IList<SataSlots> SataSlots { get; }
    public Chipset MotherBoardChipset { get; init; }
    public Socket ProcessorSocket { get; init; }
    public Ddr DdrStandart { get; init; }
    public IBios Bios { get; init; }
    public int AmountRamSlots { get; init; }
    public string FormFactor { get; init; }

    public MotherBoardBuilder Debuild(MotherBoardBuilder motherBoardBuilder)
    {
        motherBoardBuilder.WithName(Name);
        motherBoardBuilder.WithPciESlots(PciESlots);
        motherBoardBuilder.WithSataSlots(SataSlots);
        motherBoardBuilder.WithChipset(MotherBoardChipset);
        motherBoardBuilder.WithDdrStandart(DdrStandart);
        motherBoardBuilder.WithBios(Bios);
        motherBoardBuilder.WithFormFactor(FormFactor);
        return motherBoardBuilder;
    }
}