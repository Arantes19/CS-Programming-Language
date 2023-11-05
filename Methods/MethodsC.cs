using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Methods
    {
        static void Main(string[] args)
        {
            // Method = performs a section of code, whenever it's called "invoked".
            //          benefit = Let's us reuse code w/o writing it multime times

            String name = "Bro";
            int age = 21;
            SingHappyBirthday(name, age); //the method
        

        Console.ReadKey();
        }
        static void SingHappyBirthday(String name, int age) //i can change these variable names
        {
            Console.WriteLine("Happy birthday to you");
            Console.WriteLine("Happy birthday to you");
            Console.WriteLine($"Happy birthday dear {name}");
            Console.WriteLine($"You are {age} years old");
            Console.WriteLine("Happy birthday to you");
        }

    }
}