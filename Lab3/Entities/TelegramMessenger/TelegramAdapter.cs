using System;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messenger;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.TelegramMessenger;

public class TelegramAdapter : IMessenger
{
    private readonly string _api;
    private readonly long _userid;
    private IMessage? _message;

    public TelegramAdapter(Telegram telegram, string api, long userid)
    {
        TelegramMessenger = telegram;
        _api = api;
        _userid = userid;
    }

    public Telegram TelegramMessenger { get; }

    public void ReceiveMessage(IMessage message)
    {
        _message = message;
    }

    public void PrintMessage()
    {
        TelegramMessenger.SendMessage(
            _api,
            _userid,
            _message ?? throw new ArgumentNullException(nameof(_message), "cannot be null"));
    }
}