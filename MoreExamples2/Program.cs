using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreExamples2
{
    class Program
    {
        private static string _name = "Mostafa";
        public static string Name
        {
            get => _name;
            set => _name = value ?? throw new ArgumentNullException("Name", "Namw is Null");
        }

        static void Main(string[] args)
        {
            //Name = null;

            //if (Name == null)
            //    throw new ArgumentNullException(nameof(Name),"Name Must Not be null");

            //Console.WriteLine(Name);


            Person p = new Person();
            p.Name = "Mossy";
            Console.WriteLine($"Name : {p?.Name}"); // check to see if it's null
        }
    }

    class Person
    {
        public string Name { get; set; }

    }
}
