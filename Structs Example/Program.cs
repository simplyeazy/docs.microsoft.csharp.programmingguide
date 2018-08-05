using System;

namespace Structs_Example
{
    class Program
    {
        static void Main()
        {
            Example1();
            Example2();
        }

        static void Example1()
        {
            Coordinates coord1 = new Coordinates();
            Coordinates coord2 = new Coordinates(10, 10);
            Console.WriteLine("Coord 1: ");
            Console.WriteLine($"X = {coord1.x}, Y = {coord1.y}");
            Console.WriteLine("Coord 2: ");
            Console.WriteLine($"X = {coord2.x}, Y = {coord2.y}");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        static void Example2()
        {
            Coordinates coord1;
            //Initialize
            coord1.x = 10;
            coord1.y = 20;
            Console.WriteLine("Coordinate 1: ");
            Console.WriteLine($"x = {coord1.x}, y = {coord1.y}");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
