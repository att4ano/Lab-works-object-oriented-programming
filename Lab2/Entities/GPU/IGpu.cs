using Itmo.ObjectOrientedProgramming.Lab2.Entities.GPU.Builder;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.GPU;

public interface IGpu : IComponent
{
    public Dimensions Dimension { get; init; }
    public int VideoMemorySize { get; init; }
    public BaseConnector.PciE PciE { get; init; }
    public int Frequency { get; init; }
    public int PowerConsumption { get; init; }
    public GpuBuilder Debuild(GpuBuilder gpuBuilder);
}