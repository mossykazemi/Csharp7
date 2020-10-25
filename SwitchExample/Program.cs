using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchExample
{
    class Program
    {
        static void Main(string[] args)
        {

            PersonCar pc = new PersonCar("Mostafa", "Kazemi", 30, "Tesla", 3);
            

            switch (pc)
            {
                case PersonCar car when (car.CarName=="Tesla"):
                    {
                        Console.WriteLine($"Name is : {car.CarName}");
                        break;
                    }
                case Person p when (p.Age > 20):
                {
                    Console.WriteLine($"Name is : {p.Name}");
                    break;
                }
                default:
                    {
                        Console.WriteLine("Not Found");
                        break;
                    }
                case null:
                    {
                        Console.WriteLine("Is Null");
                        break;
                    }
            }

            Console.ReadKey();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public int Age { get; set; }
    }

    class PersonCar : Person
    {
        public string CarName { get; set; }
        public int CarModel { get; set; }


        public PersonCar(string name, string family, int age, string carName, int carModel)
        {
            Name = name;
            Family = family;
            Age = age;
            CarName = carName;
            CarModel = carModel;
        }
    }
}
