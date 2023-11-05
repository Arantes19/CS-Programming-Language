using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typecasting
{
    class Typecasting
    {
        static void Main(string[] args)
        {
            // Type casting = converting a value to a different data type useful when we accept user input (string)
            //               Different data types can do different things

            double a = 3.14;
            int b = Convert.ToInt32(a); //variable a is converted to Int32 and stored into variable b

            int c = 123;
            double d = Convert.ToDouble(c) + 0.1; //variable c is converted to Double and stored into variable d

            int e = 321;
            String f = Convert.ToString(e); //variable e is converted to String and stored into variable f

            String g = "$"; 
            char h = Convert.ToChar(g); //variable g is converted to Char and stored into variable h

            String i = "true";
            bool j = Convert.ToBoolean(i); //variable i is converted to Boolean and stored into variable j

            Console.WriteLine(b.GetType()); //it's also possible display the data type using ".GetType()" method
            Console.WriteLine(d.GetType()); //the data type of d is...
            Console.WriteLine(f.GetType()); //the data type of f is...
            Console.WriteLine(h.GetType());
            Console.WriteLine(j.GetType());

            Console.ReadKey();
        }
    }
}