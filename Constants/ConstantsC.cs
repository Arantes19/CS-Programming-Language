using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    class Constants
    {
        static void Main(string[] args)
        {
            // constants = immutable values which are known at compile time and do not change for the life of the program
            //             can´t update the variable noe that it's a constant and adds security to our program
            const double pi = 3.14159;
            

            Console.WriteLine(pi);

            Console.ReadKey();
        }
    }
}