using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.TelegramMessenger;

public class Telegram : ITelegram
{
    public SendResult SendMessage(string apiKey, long userId, IMessage message)
    {
        return new SendResult.Success(message);
    }
}