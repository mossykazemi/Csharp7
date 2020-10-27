using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MoreExamples
{
    class Program
    {
        //private static string _name = "Mostafa Kazemi";

        //public static string Name
        //{
        //    get { return _name;}
        //    set { _name = value; }
        //}

        public static string Name => "Mostafa Kazemi";

        static void Main(string[] args)
        {
            // Console.WriteLine(Name);

            Person p = new Person("Mostafa");
            Console.WriteLine(p.Name + " " + p.Age);
        }
    }

    class Person
    {
        public int Age { get; set; } = 30;

        private string _name;

        public string Name
        {
            //get { return _name; }
            //set { _name = value; }

            get => _name;
            set => _name = value;
        }

        public Person(string name) => Name = name;

        ~Person() => Console.WriteLine("Destructor");
    }
}

