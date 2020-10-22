using System;

namespace DeConstructExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Mostafa", "Kazemi");
            var (firstName, lastName) = p;
            Console.WriteLine($"First Name : {firstName} Last Name : {lastName}");

            //Console.WriteLine($"First Name : {p.FirstName} Last Name : {p.LastName}");
        }
    }

    class Person
    {
        private string FirstName { get; }
        private string LastName { get; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Deconstruct(out string firstName, out string lastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }
    }
}
