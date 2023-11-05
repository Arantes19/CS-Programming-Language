using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return
{
	class Return
	{
		static void Main(string[] args)
		{
			//return = return data back to the place where a method is invoked

			double x;
			double y;
			double result;

			Console.WriteLine("Enter in number 1: ");
			x = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Enter in number 2: ");
			y = Convert.ToDouble(Console.ReadLine());

			result = Multiply(x, y);
			Console.WriteLine($"{x} * {y} = {result}");

			Console.ReadKey();
		}
		static double Multiply(double x, double y)
		{
			double z = x * y;
			return z; // x * y
		}
	}
}