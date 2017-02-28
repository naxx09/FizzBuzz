using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
                if(i % 10 == 0) {
                    Console.WriteLine();
                        }
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("\tFizzBuzz");
                }
                else if(i % 3 == 0)
                {
                    Console.Write("\tFizz");
                }
                else if(i % 5 == 0)
                {
                    Console.Write("\tBuzz");
                }
                else
                {
                    Console.Write("\t{0}", i);
                }
            }
            Console.WriteLine("\nPress any key to exit");
            Console.ReadLine();
        }
    }
}
