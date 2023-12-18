using System;
using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystemElement;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystemElement.VisitorFileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.CompositeTree;

public class FileTree : IFileSystemTree
{
    private IFileSystemElement? _root;

    public void InitialiseTree(string path)
    {
        _root = Create(path);
    }

    public IFileSystemElement Create(string path)
    {
        var root = new StandardFileSystemDirectory(path);
        string[] files = Directory.GetFiles(path);
        string[] subdirectories = Directory.GetDirectories(path);
        foreach (string file in files)
        {
            root.AddElement(new StandardFileSystemFile(file));
        }

        foreach (string subdirectory in subdirectories)
        {
            root.AddElement(Create(subdirectory));
        }

        return root;
    }

    public void Accept(IVisitor visitor)
    {
        if (_root is null)
        {
            throw new ArgumentNullException(nameof(_root), "cannot be null");
        }

        _root.Accept(visitor);
    }
}