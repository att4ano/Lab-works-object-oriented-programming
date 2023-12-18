using Itmo.ObjectOrientedProgramming.Lab2.Entities.ComputerCase;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Drive;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.GPU;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.MotherBoard;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.PowerModule;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Processor;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.ProcessorCooler;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.RAM;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.WifiAdapter;
using Itmo.ObjectOrientedProgramming.Lab2.Models;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Computer.Builder;

public class ComputerBuilder
{
    private IMotherBoard? _motherBoard;
    private IProcessor? _processor;
    private IComputerCase? _computerCase;
    private IHardDrive? _hardDrive;
    private ISolidStateDrive? _solidStateDrive;
    private IPowerModule? _powerModule;
    private IProcessorCooler? _processorCooler;
    private IRam? _ram;
    private IWifiAdapter? _wifiAdapter;
    private IGpu? _gpu;
    private FullComputerValidator _validatorForComputer;

    public ComputerBuilder(FullComputerValidator validator)
    {
        _validatorForComputer = validator;
    }

    public ComputerBuilder WithMotherBoard(IMotherBoard motherBoard)
    {
        _motherBoard = motherBoard;
        return this;
    }

    public ComputerBuilder WithProcessor(IProcessor processor)
    {
        _processor = processor;
        return this;
    }

    public ComputerBuilder WithComputerCase(IComputerCase computerCase)
    {
        _computerCase = computerCase;
        return this;
    }

    public ComputerBuilder WithHardDrive(IHardDrive? hardDrive)
    {
        _hardDrive = hardDrive;
        return this;
    }

    public ComputerBuilder WithSolidStateDrive(ISolidStateDrive? solidStateDrive)
    {
        _solidStateDrive = solidStateDrive;
        return this;
    }

    public ComputerBuilder WithPowerModule(IPowerModule powerModule)
    {
        _powerModule = powerModule;
        return this;
    }

    public ComputerBuilder WithProcessorCooler(IProcessorCooler processorCooler)
    {
        _processorCooler = processorCooler;
        return this;
    }

    public ComputerBuilder WithRam(IRam ram)
    {
        _ram = ram;
        return this;
    }

    public ComputerBuilder WithWifiAdapter(IWifiAdapter? wifiAdapter)
    {
        _wifiAdapter = wifiAdapter;
        return this;
    }

    public ComputerBuilder WithGpu(IGpu? gpu)
    {
        _gpu = gpu;
        return this;
    }

    public ValidateComputerResult Build()
    {
        if (_motherBoard is not null && _processor is not null && _computerCase is not null &&
            _powerModule is not null && _processorCooler is not null && _ram is not null)
        {
            IComputer computer = new Computer(
                _motherBoard,
                _processor,
                _computerCase,
                _hardDrive,
                _solidStateDrive,
                _powerModule,
                _processorCooler,
                _ram,
                _wifiAdapter,
                _gpu);
            return _validatorForComputer.Validate(computer);
        }
        else
        {
            return new ValidateComputerResult.NoRequiredComponent();
        }
    }
}