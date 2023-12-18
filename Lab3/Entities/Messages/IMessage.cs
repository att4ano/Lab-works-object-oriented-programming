using System;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

public interface IMessage : IEquatable<IMessage>
{
    string ContentTitle { get; }
    string ContentBody { get; }
    PriorityLevel Priority { get; }
    string Render();
}
