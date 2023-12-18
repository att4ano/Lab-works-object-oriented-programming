using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressee;

public class AddresseeFilter : IAddressee
{
    private readonly IAddressee _addressee;
    private readonly PriorityLevel _priority;

    public AddresseeFilter(
        IAddressee addressee,
        int priority)
    {
        _addressee = addressee;
        _priority = new PriorityLevel(priority);
    }

    public void DirectMessage(IMessage message)
    {
        if (_priority.PriorityPoints >= message.Priority.PriorityPoints)
        {
            _addressee.DirectMessage(message);
        }
    }
}