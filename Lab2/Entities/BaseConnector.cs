namespace Itmo.ObjectOrientedProgramming.Lab2.Entities;

public abstract record BaseConnector
{
    private BaseConnector(int version)
    {
        Version = version;
    }

    public int Version { get; init; }

    public sealed record PciE : BaseConnector
    {
        public PciE(int version)
            : base(version)
        {
        }
    }

    public sealed record Sata : BaseConnector
    {
        public Sata(int version)
            : base(version)
        {
        }
    }
}