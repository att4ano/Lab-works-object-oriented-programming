using Itmo.ObjectOrientedProgramming.Lab2.Entities.ComputerCase.Builder;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.ComputerCase;

public class ComputerCase : IComputerCase
{
    public ComputerCase(
        string name,
        Dimensions dimension,
        Dimensions maxVideoCardDimension,
        string motherBoardFormFactor)
    {
        Name = name;
        Dimension = dimension;
        MaxVideoCardDimension = maxVideoCardDimension;
        MotherBoardFormFactor = motherBoardFormFactor;
    }

    public string Name { get; init; }
    public Dimensions Dimension { get; init; }
    public Dimensions MaxVideoCardDimension { get; init; }
    public string MotherBoardFormFactor { get; init; }

    public ComputerCaseBuilder Debuild(ComputerCaseBuilder computerCaseBuilder)
    {
        computerCaseBuilder.WithName(Name);
        computerCaseBuilder.WithDimension(Dimension);
        computerCaseBuilder.WithMaxVideoCardDimensions(MaxVideoCardDimension);
        computerCaseBuilder.WithMotherBoardFormFactor(MotherBoardFormFactor);
        return computerCaseBuilder;
    }
}