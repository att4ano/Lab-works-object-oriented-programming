using Itmo.ObjectOrientedProgramming.Lab2.Entities.GPU.Builder;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.GPU;

public class Gpu : IGpu
{
    public Gpu(
        string name,
        Dimensions dimension,
        int videoMemorySize,
        BaseConnector.PciE pciE,
        int frequency,
        int powerConsumption)
    {
        Name = name;
        Dimension = dimension;
        VideoMemorySize = videoMemorySize;
        PciE = pciE;
        Frequency = frequency;
        PowerConsumption = powerConsumption;
    }

    public string Name { get; init; }
    public Dimensions Dimension { get; init; }
    public int VideoMemorySize { get; init; }
    public BaseConnector.PciE PciE { get; init; }
    public int Frequency { get; init; }
    public int PowerConsumption { get; init; }
    public GpuBuilder Debuild(GpuBuilder gpuBuilder)
    {
        gpuBuilder.WithName(Name);
        gpuBuilder.WithDimensions(Dimension);
        gpuBuilder.WithVideoMemorySize(VideoMemorySize);
        gpuBuilder.WithPciE(PciE);
        gpuBuilder.WithFrequency(Frequency);
        gpuBuilder.WithPowerConsumption(PowerConsumption);
        return gpuBuilder;
    }
}