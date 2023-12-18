using System;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Users;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressee.Builder;

public class UserAddresseeBuilder : IAddresseeBuilder
{
    private IUser? _user;

    public UserAddresseeBuilder WithUser(IUser user)
    {
        _user = user;
        return this;
    }

    public IAddressee Build()
    {
        return new UserAddressee(
            _user ?? throw new ArgumentNullException(nameof(_user), "cannot be null"));
    }
}