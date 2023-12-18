namespace Itmo.ObjectOrientedProgramming.Lab2.Models;

public record Dimensions
{
    public Dimensions(int length, int width, int height)
    {
        Length = length;
        Width = width;
        Height = height;
    }

    public int Length { get; init; }
    public int Width { get; init; }
    public int Height { get; init; }

    public static bool operator <=(Dimensions left, Dimensions right)
    {
        return left.Width <= right.Width && left.Height <= right.Height && left.Length <= right.Length;
    }

    public static bool operator >=(Dimensions left, Dimensions right)
    {
        return left.Width >= right.Width && left.Height >= right.Height && left.Length >= right.Length;
    }

    public bool CompareTo(Dimensions other)
    {
        return this.Width <= other.Width && this.Height <= other.Height && this.Length <= other.Length;
    }
}