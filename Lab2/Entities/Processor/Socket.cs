namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Processor;

public class Socket
{
    public Socket(string socketModelName)
    {
        SocketModelName = socketModelName;
    }

    public string SocketModelName { get; init; }
}