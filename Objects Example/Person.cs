namespace Objects_Example
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        // Other properties, method, events..
    }

    public struct StructPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public StructPerson(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }
}
