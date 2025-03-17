using System;

public interface IButton
{
    void Click();
}

public interface ITextField
{
    void SetText(string text);
}

public class WindowsButton : IButton
{
    public void Click() => Console.WriteLine("Windows Button Clicked");
}

public class MacOSButton : IButton
{
    public void Click() => Console.WriteLine("MacOS Button Clicked");
}

public class WindowsTextField : ITextField
{
    public void SetText(string text) => Console.WriteLine($"Windows TextField: {text}");
}

public class MacOSTextField : ITextField
{
    public void SetText(string text) => Console.WriteLine($"MacOS TextField: {text}");
}

public interface IGUIFactory
{
    IButton CreateButton();
    ITextField CreateTextField();
}

public class WindowsFactory : IGUIFactory
{
    public IButton CreateButton() => new WindowsButton();
    public ITextField CreateTextField() => new WindowsTextField();
}

public class MacOSFactory : IGUIFactory
{
    public IButton CreateButton() => new MacOSButton();
    public ITextField CreateTextField() => new MacOSTextField();
}