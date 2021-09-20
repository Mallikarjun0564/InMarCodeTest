using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int i = 0;
            Console.WriteLine("please enter Number");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------");
            while(i <= number)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                i++;
            }
            Console.ReadLine();
        }
    }
}
