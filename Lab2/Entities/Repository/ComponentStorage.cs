using Itmo.ObjectOrientedProgramming.Lab2.Entities.BIOS;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.ComputerCase;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Drive;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.GPU;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.MotherBoard;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.PowerModule;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Processor;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.ProcessorCooler;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.RAM;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.WifiAdapter;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Repository;

public class ComponentStorage
{
    public ComponentStorage(
        Storage<IMotherBoard> availableMotherBoards,
        Storage<IBios> availableBios,
        Storage<IComputerCase> availableComputerCase,
        Storage<IHardDrive> availableHardDrive,
        Storage<ISolidStateDrive> availableSolidStateDrive,
        Storage<IGpu> availableGpu,
        Storage<IPowerModule> availablePowerModule,
        Storage<IProcessor> availableProcessor,
        Storage<IProcessorCooler> availableProcessorCooler,
        Storage<IRam> availableRam,
        Storage<IWifiAdapter> availableWifiAdapter)
    {
        AvailableMotherBoards = availableMotherBoards;
        AvailableBios = availableBios;
        AvailableComputerCase = availableComputerCase;
        AvailableHardDrive = availableHardDrive;
        AvailableSolidStateDrive = availableSolidStateDrive;
        AvailableGpu = availableGpu;
        AvailablePowerModule = availablePowerModule;
        AvailableProcessor = availableProcessor;
        AvailableProcessorCooler = availableProcessorCooler;
        AvailableRam = availableRam;
        AvailableWifiAdapter = availableWifiAdapter;
    }

    public Storage<IMotherBoard> AvailableMotherBoards { get; }
    public Storage<IBios> AvailableBios { get; }
    public Storage<IComputerCase> AvailableComputerCase { get; }
    public Storage<IHardDrive> AvailableHardDrive { get; }
    public Storage<ISolidStateDrive> AvailableSolidStateDrive { get; }
    public Storage<IGpu> AvailableGpu { get; }
    public Storage<IPowerModule> AvailablePowerModule { get; }
    public Storage<IProcessor> AvailableProcessor { get; }
    public Storage<IProcessorCooler> AvailableProcessorCooler { get; }
    public Storage<IRam> AvailableRam { get; }
    public Storage<IWifiAdapter> AvailableWifiAdapter { get; }
}