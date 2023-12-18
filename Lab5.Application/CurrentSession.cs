using Lab5.Application.Models.Users;

namespace Lab5.Application;

public abstract record CurrentSession
{
    private CurrentSession() { }

    public sealed record UserSession : CurrentSession
    {
        public UserSession(User user)
        {
            User = user;
        }

        public User User { get; set; }
    }

    public sealed record AdminSession : CurrentSession
    {
        public AdminSession(Admin admin)
        {
            Admin = admin;
        }

        public Admin Admin { get; set; }
    }

    public sealed record UnauthorizedSession : CurrentSession;
}