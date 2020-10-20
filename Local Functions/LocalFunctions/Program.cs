using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            MyNumber();

            void MyNumber()
            {
                int myFavNumber = 123;
                Console.WriteLine(myFavNumber);
            }


            int AddTen(int n)
            {
                return n + 10;
            }
            Console.WriteLine(AddTen(20));


            int myValue = 1;
            int Calculate(int n) => (n < 2) ? myValue : Calculate(n - 1) + Calculate(n - 2);
            Console.WriteLine(Calculate(8));


            Console.ReadKey();
        }

        public IEnumerable<T> Filter<T>(IEnumerable<T> source, Func<T, bool> filter)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (filter == null) throw new ArgumentNullException(nameof(filter));

            return Iterator();

            IEnumerable<T> Iterator()// this is a Local Function
            {
                foreach (var element in source)
                {
                    if (filter(element))
                    {
                        yield return element;
                    }
                }
            }
        }
    }
}
