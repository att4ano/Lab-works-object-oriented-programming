using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.BIOS;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.MotherBoard.Builder;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Processor;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.RAM;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.WifiAdapter;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.MotherBoard;

public interface IMotherBoard : IComponent
{
    public IList<PcieSlots> PciESlots { get; }
    public IList<SataSlots> SataSlots { get; }
    public Chipset MotherBoardChipset { get; init; }
    public Socket ProcessorSocket { get; init; }
    public Ddr DdrStandart { get; init; }
    public IBios Bios { get; init; }
    public int AmountRamSlots { get; init; }
    public string FormFactor { get; init; }
    public MotherBoardBuilder Debuild(MotherBoardBuilder motherBoardBuilder);
}