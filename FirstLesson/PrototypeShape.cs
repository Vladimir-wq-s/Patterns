using System;

public abstract class Shape
{
    public abstract Shape Clone();
    public abstract void DisplayInfo();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public Circle()
    {
    }

    public override Shape Clone() => new Circle(Radius);

    public override void DisplayInfo()
    {
        Console.WriteLine($"Circle with Radius: {Radius}");
    }
}

public class Square : Shape
{
    public double SideLength { get; set; }

    public Square(double sideLength)
    {
        SideLength = sideLength;
    }

    public Square()
    {
    }

    public override Shape Clone() => new Square(SideLength);

    public override void DisplayInfo()
    {
        Console.WriteLine($"Square with Side Length: {SideLength}");
    }
}

public class Program
{
    public static void main()
    {
        Shape circle = new Circle(5);
        Shape clonedCircle = circle.Clone();

        Shape square = new Square(4);
        Shape clonedSquare = square.Clone();

       
        Console.WriteLine("Original Shapes:");
        circle.DisplayInfo();
        square.DisplayInfo();

        Console.WriteLine("\nCloned Shapes:");
        clonedCircle.DisplayInfo();
        clonedSquare.DisplayInfo();
    }
}