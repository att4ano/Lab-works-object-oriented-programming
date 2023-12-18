using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.RAM.Builder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.RAM;

public interface IRam : IComponent
{
    public int RamSize { get; init; }
    public IList<RamProfile> RamJedec { get; init; }
    public int Amount { get; init; }
    public IList<RamProfile> RamXmp { get; init; }
    public Ddr Ddr { get; init; }
    public int PowerConsumption { get; init; }
    public string FormFactor { get; init; }
    public RamBuilder Debuild(RamBuilder ramBuilder);
}