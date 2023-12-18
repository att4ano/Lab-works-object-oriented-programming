namespace Lab5.Application;

public interface ICurrentUserManager
{
    public CurrentSession? CurrentSession { get; set; }
}