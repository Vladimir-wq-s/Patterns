using System;
public interface ICoolingStrategy
{
    void Cool();
}


public class AirCoolingStrategy : ICoolingStrategy
{
    public void Cool()
    {
        Console.WriteLine("Cooling the CPU with air cooling.");
    }
}


public class LiquidCoolingStrategy : ICoolingStrategy
{
    public void Cool()
    {
        Console.WriteLine("Cooling the CPU with liquid cooling.");
    }
}


public class CPU
{
    private ICoolingStrategy _coolingStrategy;

    public void SetCoolingStrategy(ICoolingStrategy coolingStrategy)
    {
        _coolingStrategy = coolingStrategy;
    }

    public void Cool()
    {
        _coolingStrategy.Cool();
    }
}