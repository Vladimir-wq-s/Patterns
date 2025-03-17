using System;

namespace Patterns.FirstLesson
{
    public class Program
    {
        public static void main (string[] args)
        {
            
            Shape circle = new Circle();
            Shape square = new Square();

            Shape clonedCircle = circle.Clone();
            Shape clonedSquare = square.Clone();

            
            DisplayShapeInfo(clonedCircle);
            DisplayShapeInfo(clonedSquare);
        }

        private static void DisplayShapeInfo(Shape shape)
        {
            Console.WriteLine($"Cloned Shape: {shape.GetType().Name}");
        }
    }
}