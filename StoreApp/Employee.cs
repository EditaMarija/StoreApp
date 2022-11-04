
namespace StoreApp
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }

        public Employee(string name, int age, string position)
        {
            Name = name;
            Age = age;
            Position = position;
        }
    }
}