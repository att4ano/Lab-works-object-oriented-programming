using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Deflector;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Engine;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Engine.EngineInterfaces;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Hull;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Ship.ShipInterfaces;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Models.Points;

namespace Itmo.ObjectOrientedProgramming.Lab1.SpaceTransportSystem.Entities.Ship;

public class VaklasShip : IBaseShipWithDeflector, IBaseShipWithJumpEngine
{
    public VaklasShip()
    {
    }

    public IImpulseEngine ImpulseEngine { get; } = new ImpulseEngineE();
    public IBaseHull Hull { get; } = new HullSecondClass();
    public bool IsCrewAlive { get; } = true;

    public IDeflector Deflector { get; private set; } = new DeflectorFirstClass();

    public IJumpEngine JumpEngine { get; } = new GammaJumpEngine();

    public void MakePhotonic()
    {
        Deflector = new PhotonicDeflector(Deflector);
    }

    public void TakeDamage(decimal damage)
    {
        if (Deflector.Health < damage)
        {
            damage -= Deflector.Health;
            Deflector.TakeDamage(Deflector.Health);
        }
        else
        {
            Deflector.TakeDamage(new HealthPoints(damage));
            damage = 0;
        }

        damage *= (decimal)Hull.GetDamageCoefficient;
        Hull.TakeDamage(Hull.Health < damage ? Hull.Health : new HealthPoints(damage));
    }
}