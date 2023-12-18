using Itmo.ObjectOrientedProgramming.Lab3.Entities.MessageLogger;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressee;

public class AddresseeLogger : IAddressee
{
    private readonly IAddressee _addressee;
    private readonly ILogger _logger;

    public AddresseeLogger(
        IAddressee addressee,
        ILogger logger)
    {
        _addressee = addressee;
        _logger = logger;
    }

    public void DirectMessage(IMessage message)
    {
        _logger.MakeLog(message);
        _addressee.DirectMessage(message);
    }
}