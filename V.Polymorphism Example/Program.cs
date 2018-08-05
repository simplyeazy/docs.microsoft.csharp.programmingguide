using System;
using System.Collections.Generic;

namespace V.Polymorphism_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>
            {
                new Rectangle(),
                new Triangle(),
                new Circle()
            };
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
