namespace Itmo.ObjectOrientedProgramming.Lab1.TravelServices.Entities;

public class FuelExchange
{
    private const decimal MoneyPerOrdinaryFuel = 50;
    private const decimal MoneyPerGravityFuel = 100;

    public FuelExchange(decimal ordinaryFuelAmount, decimal gravityFuelAmount)
    {
        OrdinaryFuelPrice = MoneyPerOrdinaryFuel * ordinaryFuelAmount;
        GravityFuelPrice = MoneyPerGravityFuel * gravityFuelAmount;
    }

    public decimal OrdinaryFuelPrice { get; }
    public decimal GravityFuelPrice { get; }
}