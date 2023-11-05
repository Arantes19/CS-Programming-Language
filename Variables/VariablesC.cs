using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Variables
    {
        static void Main()
        {
            int x; //declaration
            x = 123; //inicialization

            int y = 321; //declaration + inicialization
            int z = x + y;

            int age = 21; // whole integer
            double height = 300.5; //decimal number
            bool alive = true;
            char symbol = '@';
            string name = "Francisco";

            Console.WriteLine($"Are you alive? {alive}");
            Console.WriteLine($"Your age is {age}");
            Console.WriteLine($"Your height is {height}cm");
            Console.WriteLine($"Your symbol is {symbol}");
            Console.WriteLine($"Hello {name}");

            String username = symbol + name;

            Console.WriteLine($"Your username is {username}");

            Console.ReadKey();
        }
    }
}