using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tuple<string, string, int> Person = Tuple.Create("Mostafa", "Kazemi", 24);
            //Console.WriteLine($"First Name : {Person.Item1} , LastName : {Person.Item2} , Age : {Person.Item3}");

            //Exam1();
            //Exam2();
            //Exam3();
            Exam4();
            Console.ReadKey();
        }

        static void Exam1()
        {
            var person = new Tuple<string, string, int>("Mostafa", "kazemi", 24);
            Console.WriteLine($"First Name : {person.Item1} , LastName : {person.Item2} , Age : {person.Item3}");
        }

        static void Exam2()
        {
            var info = Tuple.Create("Mostafa Kazemi", "09217701362", "m.kazemi.512@gmail.com", "Software Enginner");
            Console.WriteLine($"{info.Item1} - {info.Item2} - {info.Item3} - {info.Item4}");
        }

        static void Exam3()
        {
            var nestedTuple = new Tuple<int, int, int, int, int, int, int,
                Tuple<string, string>>(1, 2, 3, 4, 5, 6, 7, Tuple.Create("Mostafa", "Kazemi"));
            Console.WriteLine("{0},{1},{2}", nestedTuple.Item2, nestedTuple.Rest.Item1, nestedTuple.Rest.Item2);
        }

        static void Exam4()
        {
            TupleSample ts = new TupleSample();
            var person = Tuple.Create("Mostafa", "Kazemi", 24);
            ts.SetTupleInMethod(person);
        }

        static void Exam5()
        {
            var person = TupleSample.GetTuple();
            Console.WriteLine($"First Name : {person.Item1} , LastName : {person.Item2} , Age : {person.Item3}");
        }
    }

    public class TupleSample
    {
        public void SetTupleInMethod(Tuple<string, string, int> person)
        {
            Console.WriteLine($"First Name : {person.Item1} , LastName : {person.Item2} , Age : {person.Item3}");
        }

        public static Tuple<string, string, int> GetTuple()
        {
            return Tuple.Create("Mostafa", "Kazemi", 24);
        }
    }
}
