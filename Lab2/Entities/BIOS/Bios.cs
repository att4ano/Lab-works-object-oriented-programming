using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.BIOS.Builder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.BIOS;

public class Bios : IBios
{
    public Bios(
        string name,
        int version,
        string biosType,
        IReadOnlyCollection<string> listOfSupportedProcessors)
    {
        Version = version;
        BiosType = biosType;
        Name = name;
        ListOfSupportedProcessors = listOfSupportedProcessors.ToList();
    }

    public string Name { get; init; }
    public int Version { get; init; }
    public string BiosType { get; init; }
    public IList<string> ListOfSupportedProcessors { get; init; }

    public BiosBuilder Debuild(BiosBuilder biosBuilder)
    {
        biosBuilder.WihName(Name);
        biosBuilder.WithVersion(Version);
        biosBuilder.WithBiosType(BiosType);
        foreach (string t in ListOfSupportedProcessors)
        {
            biosBuilder.WithSupportedProcessor(t);
        }

        return biosBuilder;
    }
}