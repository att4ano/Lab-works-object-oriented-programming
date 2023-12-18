using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Computer;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services;

public class MotherBoardProcessorValidator : IValidator
{
    public MotherBoardProcessorValidator() { }

    public AddComponentResult Validate(IComputer computer)
    {
        if (computer.MotherBoard.ProcessorSocket.SocketModelName != computer.Processor.RequiredSocket.SocketModelName)
            return new AddComponentResult.Failure("The processor is not compatible with the socket");
        if (computer.MotherBoard.Bios.ListOfSupportedProcessors.Any(socketName =>
                computer.Processor.Name == socketName))
        {
            return new AddComponentResult.Success("Success");
        }

        return new AddComponentResult.Failure("Bios doesn't support current processor");
    }
}