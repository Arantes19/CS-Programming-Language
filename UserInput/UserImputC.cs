using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Userinput
{
    class Userinput
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your name?");
            String name = Console.ReadLine();

            Console.WriteLine("Whats your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Hello {name}");
            Console.Write($"You are {age} years old");


            Console.ReadKey();
        }
    }
}