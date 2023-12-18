namespace Lab5.Application;

public class CurrentUserManager : ICurrentUserManager
{
    public CurrentSession? CurrentSession { get; set; }
}