using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.TelegramMessenger;

public interface ITelegram
{
    SendResult SendMessage(string apiKey, long userId, IMessage message);
}