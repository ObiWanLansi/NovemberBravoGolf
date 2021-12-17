using System;

using SmallThings.Shapes;



namespace SmallThings
{
    static class Program
    {
        private static void Main(string[] args)
        {
            Circle circle = new Circle(5);

            Console.Out.WriteLine($"Kreis: {circle}");

            Rectangle rect = new Rectangle(0, 0, 40, 30);
            
            Console.Out.WriteLine($"Rechteck: {rect}");

            Console.ReadKey(true);
        }
    }
}
