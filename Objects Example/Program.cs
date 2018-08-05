using System;

namespace Objects_Example
{
    class Program
    {
        static void Main()
        {
            //Example1();
            //Example2();
            //Example3();
        }

        // ReSharper disable once UnusedMember.Local
        static void Example1()
        {
            Person person1 = new Person("Leopold", 6);
            Console.WriteLine($"Person1 name = {person1.Name} Age = {person1.Age}");
            // Declare new person, assign person1 to it
            Person person2 = person1;
            //Console.WriteLine($"Person2 name = {person2.Name} Age = {person2.Age}");
            person2.Name = "Molly";
            person2.Age = 16;
            Console.WriteLine($"Person2 name = {person2.Name} Age = {person2.Age}");
            Console.WriteLine($"Person1 name = {person1.Name} Age = {person1.Age}");
            Console.ReadKey();
        }

        static void Example2()
        {
            // Create  struct instance and initialize by using "new".
            // Memory is allocated on thread stack.
            StructPerson p1 = new StructPerson("Alex", 9);
            Console.WriteLine($"P1 Name = {p1.Name} Age = {p1.Age}");
            // Create  new struct object. Note that  struct can be initialized
            // without using "new".
            StructPerson p2 = p1;
            // Assign values to p2 members.
            p2.Name = "Spencer";
            p2.Age = 7;
            Console.WriteLine($"P2 Name = {p2.Name} Age = {p2.Age}");
            // p1 values remain unchanged because p2 is  copy.
            Console.WriteLine($"P1 Name = {p1.Name} Age = {p1.Age}");
            // Keep the console open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static void Example3()
        {
            Person p1 = new Person("Wallace", 75);
            Person p2 = null;
            p2.Name = "Wallace";
            p2.Age = 75;
            if (p2.Equals(p1))
            {
                Console.WriteLine("Equal");
            }
            Console.ReadKey();

        }
    }
}
