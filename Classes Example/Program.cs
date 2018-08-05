using System;

namespace Classes_Example
{
    class Program
    {
        private static void Main()
        {
            Person person1 = new Person();
            Console.WriteLine(person1.Name);
            person1.SetName("John Smith");
            Console.WriteLine(person1.Name);

            Person person2 = new Person("Sarah Jones");
            Console.WriteLine(person2.Name);
            Console.ReadKey();
        }
    }
}
