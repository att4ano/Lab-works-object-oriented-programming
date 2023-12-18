using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.RAM.Builder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.RAM;

public class Ram : IRam
{
    public Ram(
        int ramSize,
        int amount,
        IList<RamProfile> ramJedec,
        IList<RamProfile> ramXmp,
        Ddr ddr,
        int powerConsumption,
        string nameOfRam,
        string formFactor)
    {
        RamSize = ramSize;
        Amount = amount;
        RamJedec = ramJedec;
        RamXmp = ramXmp;
        Ddr = ddr;
        PowerConsumption = powerConsumption;
        Name = nameOfRam;
        FormFactor = formFactor;
    }

    public int RamSize { get; init; }

    public IList<RamProfile> RamJedec { get; init; }

    public IList<RamProfile> RamXmp { get; init; }

    public Ddr Ddr { get; init; }

    public int PowerConsumption { get; init; }
    public string Name { get; init; }

    public int Amount { get; init; }
    public string FormFactor { get; init; }

    public RamBuilder Debuild(RamBuilder ramBuilder)
    {
        ramBuilder.WithRamName(Name);
        ramBuilder.WithRamSize(RamSize);
        foreach (RamProfile ramProfile in RamJedec)
        {
            ramBuilder.WithJedec(ramProfile);
        }

        ramBuilder.WithDdr(Ddr);
        foreach (RamProfile ramProfile in RamXmp)
        {
            ramBuilder.WithXmp(ramProfile);
        }

        ramBuilder.WithPowerConsumption(PowerConsumption);
        return ramBuilder;
    }
}