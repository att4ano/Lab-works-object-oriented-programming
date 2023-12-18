namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.WifiAdapter;

public class SataSlots
{
    public SataSlots(int version, int amount)
    {
        Sata = new BaseConnector.Sata(version);
        Amount = amount;
    }

    public BaseConnector.Sata Sata { get; init; }
    public int Amount { get; private set; }

    public void MakeConnect()
    {
        --Amount;
    }
}