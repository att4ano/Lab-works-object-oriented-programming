namespace Lab5.Application.Models;

public record Money
{
    public Money(long value)
    {
        Value = value;
    }

    public long Value { get; }
}