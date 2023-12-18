using Itmo.ObjectOrientedProgramming.Lab2.Entities.Computer.Builder;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.ComputerCase;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Drive;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.GPU;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.MotherBoard;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.PowerModule;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Processor;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.ProcessorCooler;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.RAM;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.WifiAdapter;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Computer;

public interface IComputer
{
    public IMotherBoard MotherBoard { get; init; }
    public IProcessor Processor { get; init; }
    public IComputerCase ComputerCase { get; init; }
    public IHardDrive? HardDrive { get; init; }
    public ISolidStateDrive? SolidStateDrive { get; init; }
    public IPowerModule PowerModule { get; init; }
    public IProcessorCooler ProcessorCooler { get; init; }
    public IRam Ram { get; init; }
    public IWifiAdapter? WifiAdapter { get; init; }
    public IGpu? Gpu { get; init; }

    public ComputerBuilder Debuild(ComputerBuilder computerBuilder);
}