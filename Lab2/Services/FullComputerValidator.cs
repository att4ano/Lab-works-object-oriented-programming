using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Computer;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services;

public class FullComputerValidator
{
    private readonly IReadOnlyCollection<IValidator> _validatorList;

    public FullComputerValidator(IReadOnlyCollection<IValidator> validatorList)
    {
        _validatorList = validatorList;
    }

    public ValidateComputerResult Validate(IComputer computer)
    {
        bool heatDissipationFlag = false;
        bool powerConsumptionFlag = false;
        IEnumerable<AddComponentResult> report = _validatorList.Select(x => x.Validate(computer));
        foreach (AddComponentResult result in report)
        {
            if (result is AddComponentResult.Failure failure)
            {
                return new ValidateComputerResult.Failure(failure.Message);
            }
            else if (result is AddComponentResult.PowerConsumptionWarning)
            {
                powerConsumptionFlag = true;
            }
            else if (result is AddComponentResult.HeatDissipationWarning)
            {
                heatDissipationFlag = true;
            }
        }

        if (heatDissipationFlag)
        {
            return new ValidateComputerResult.DisclaimerOfWaranty(computer);
        }

        if (powerConsumptionFlag)
        {
            return new ValidateComputerResult.PowerConsumptionComment(computer);
        }

        return new ValidateComputerResult.Success(computer);
    }
}