using Itmo.ObjectOrientedProgramming.Lab2.Entities.ComputerCase.Builder;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.ComputerCase;

public interface IComputerCase : IComponent
{
    public Dimensions Dimension { get; init; }
    public Dimensions MaxVideoCardDimension { get; init; }
    public string MotherBoardFormFactor { get; init; }
    public ComputerCaseBuilder Debuild(ComputerCaseBuilder computerCaseBuilder);
}