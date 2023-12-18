using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.BIOS.Builder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.BIOS;

public interface IBios : IComponent
{
    public int Version { get; init; }
    public string BiosType { get; init; }
    public IList<string> ListOfSupportedProcessors { get; init; }
    public BiosBuilder Debuild(BiosBuilder biosBuilder);
}