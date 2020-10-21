using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = TupleSample.GetNewTuple();
            Console.WriteLine($"First Name : {person.Item1} , LastName : {person.Item2} , Age : {person.Item3}");

            var Info = TupleSample.GetPerson();
            Console.WriteLine($"{Info.firstName} - {Info.lastName} - {Info.age}");


            Console.ReadKey();
        }
    }

    class TupleSample
    {
        public static (string, string, int) GetNewTuple()
        {
            string firstName = "Mostafa";
            string lastName = "Kazemi";
            int age = 24;

            return (firstName, lastName, age);
        }

        public static (string firstName, string lastName, int age) GetPerson()
        {
            string firstName = "Mostafa";
            string lastName = "Kazemi";
            int age = 24;

            return (firstName, lastName, age);
        }
    }
}
