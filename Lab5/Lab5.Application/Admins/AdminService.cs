using Lab5.Application.Abstractions.Repositories;
using Lab5.Application.Contracts;
using Lab5.Application.Contracts.Admins;
using Lab5.Application.Models.Users;

namespace Lab5.Application.Admins;

public class AdminService : IAdminService
{
    private readonly IUserRepository _userRepository;
    private readonly IAdminRepository _adminRepository;
    private readonly CurrentUserManager _currentUserManager;

    public AdminService(
        IUserRepository userRepository,
        IAdminRepository adminRepository,
        CurrentUserManager currentUserManager)
    {
        _userRepository = userRepository;
        _adminRepository = adminRepository;
        _currentUserManager = currentUserManager;
        _currentUserManager.CurrentSession = new CurrentSession.UnauthorizedSession();
    }

    public async Task<LoginResult> Login(string password)
    {
        if (_currentUserManager.CurrentSession is not CurrentSession.UnauthorizedSession)
        {
            return new LoginResult.Failure();
        }

        Admin? admin = await _adminRepository.FindAdmin(password);
        if (admin is null)
        {
            return new LoginResult.NotFound();
        }

        _currentUserManager.CurrentSession = new CurrentSession.AdminSession(admin);
        return new LoginResult.Success();
    }

    public async Task CreateNewUser(string username, string password)
    {
        if (_currentUserManager.CurrentSession is CurrentSession.UnauthorizedSession)
        {
            return;
        }

        if (await _userRepository.FindUserByUsername(username) is not null)
        {
            return;
        }

        await _userRepository.AddNewUser(username, password);
    }
}