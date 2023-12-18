using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Users.Builder;

public class UserBuilder
{
    private string? _name;

    public UserBuilder WithName(string name)
    {
        _name = name;
        return this;
    }

    public User Build()
    {
        return new User(
            _name ?? throw new ArgumentNullException(nameof(_name), "cannot be null"));
    }
}