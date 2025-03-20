using System;
using System.Collections.Generic;

public interface IObserver
{
    void Update(float temperature);
}


public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}


public class TemperatureSensor : ISubject
{
    private List<IObserver> _observers = new List<IObserver>();
    private float _temperature;

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        for (int i = 0; i < _observers.Count; i++) 
        {
            _observers[i].Update(_temperature);
        }
    }

    public void SetTemperature(float temperature)
    {
        _temperature = temperature;
        Notify();
    }
}


public class CPUObserver : IObserver
{
    public void Update(float temperature)
    {
        Console.WriteLine($"CPU: Temperature updated to {temperature}°C.");
    }
}


public class GPUObserver : IObserver
{
    public void Update(float temperature)
    {
        Console.WriteLine($"GPU: Temperature updated to {temperature}°C.");
    }
}