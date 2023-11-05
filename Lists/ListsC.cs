using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class ListsC
    {
        static void Main(string[] args)
        {
            // List = data structure that represents a list of objects that can be accessed by index.
            //        Similar to array, but can dynamically increase/decrease in size 
            //        using System.Collections.Generic;

            List<String> food = new List<String>();
            
            food.Add("pizza"); //add an item
            food.Add("hamburger");
            food.Add("hotdog");  
            food.Add("fries");

            //food.Remove("fries"); //remove an item
            //Console.WriteLine(food[0]);

            //food.Insert(0, "sushi"); //insert an item on a certain index

            //Console.WriteLine(food.Count); //number of items
            //Console.WriteLine(food.IndexOf("pizza")); //index of pizza

            //Console.WriteLine(food.LastIndexOf("fries"));

            //Console.WriteLine(food.Contains("pizza")); //true or false if pizza is on the list

            //food.Sort();

            //food.Reverse();

            //food.Clear();

            //String[] foodArray = food.ToArray(); //transform into a array

            foreach (String item in food/*foodArray*/)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}