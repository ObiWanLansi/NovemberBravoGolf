using System;

using HelloTest.Shapes;



namespace HelloTest
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
