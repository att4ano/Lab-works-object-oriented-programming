using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4.Models;

public record Context
{
    public string? ContextPath { get; private set; }

    public void SetNewContext(string? path)
    {
        ContextPath = path;
    }

    public bool FileReachabilityCheck(string filePath)
    {
        if (ContextPath is null)
            return false;
        if (Path.IsPathFullyQualified(filePath))
            return false;
        filePath = Path.Combine(ContextPath, filePath);

        return File.Exists(filePath);
    }
}