using System;

using SmallThings.Shapes;



namespace SmallThings
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);

            Console.Out.WriteLine($"Kreis: {circle}");

            Console.ReadKey(true);
        }
    }
}
