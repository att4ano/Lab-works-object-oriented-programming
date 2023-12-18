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

public class Computer : IComputer
{
    public Computer(
        IMotherBoard motherBoard,
        IProcessor processor,
        IComputerCase computerCase,
        IHardDrive? hardDrive,
        ISolidStateDrive? solidStateDrive,
        IPowerModule powerModule,
        IProcessorCooler processorCooler,
        IRam ram,
        IWifiAdapter? wifiAdapter,
        IGpu? gpu)
    {
        MotherBoard = motherBoard;
        Processor = processor;
        ComputerCase = computerCase;
        HardDrive = hardDrive;
        SolidStateDrive = solidStateDrive;
        PowerModule = powerModule;
        ProcessorCooler = processorCooler;
        Ram = ram;
        WifiAdapter = wifiAdapter;
        Gpu = gpu;
    }

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

    public ComputerBuilder Debuild(ComputerBuilder computerBuilder)
    {
        computerBuilder.WithMotherBoard(MotherBoard);
        computerBuilder.WithProcessor(Processor);
        computerBuilder.WithComputerCase(ComputerCase);
        computerBuilder.WithSolidStateDrive(SolidStateDrive);
        computerBuilder.WithHardDrive(HardDrive);
        computerBuilder.WithPowerModule(PowerModule);
        computerBuilder.WithProcessorCooler(ProcessorCooler);
        computerBuilder.WithRam(Ram);
        computerBuilder.WithWifiAdapter(WifiAdapter);
        computerBuilder.WithGpu(Gpu);
        return computerBuilder;
    }
}