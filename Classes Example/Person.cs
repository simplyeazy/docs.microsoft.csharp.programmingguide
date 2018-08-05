namespace Classes_Example
{
    public class Person
    {
        // Field
        public string Name;

        // Constructor that takes no arguments.
        public Person()
        {
            Name = "unknown";
        }

        // Constructor that takes one argument.
        public Person(string nm)
        {
            Name = nm;
        }

        // Method
        public void SetName(string newName)
        {
            Name = newName;
        }
    }
}
