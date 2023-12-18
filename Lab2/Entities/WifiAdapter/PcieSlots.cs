namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.WifiAdapter;

public class PcieSlots
{
    public PcieSlots(int version, int amount)
    {
        PciE = new BaseConnector.PciE(version);
        Amount = amount;
    }

    public BaseConnector.PciE PciE { get; init; }
    public int Amount { get; private set; }

    public void MakeConnect()
    {
        --Amount;
    }
}