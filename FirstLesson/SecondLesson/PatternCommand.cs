using System;
public interface ICommand
{
    void Execute();
}


public class TurnOnCommand : ICommand
{
    private readonly string _component;

    public TurnOnCommand(string component)
    {
        _component = component;
    }

    public void Execute()
    {
        Console.WriteLine($"{_component} is turned on.");
    }
}


public class TurnOffCommand : ICommand
{
    private readonly string _component;

    public TurnOffCommand(string component)
    {
        _component = component;
    }

    public void Execute()
    {
        Console.WriteLine($"{_component} is turned off.");
    }
}


public class RemoteControl
{
    private ICommand _command;

    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void PressButton()
    {
        _command.Execute();
    }
}