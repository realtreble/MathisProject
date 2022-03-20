using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            List<int> numbers2 = new List<int>();
            int[] array = new int[] { 1, 2, 3 };
            numbers2.AddRange(array);

            List<string> fruits = new List<string>();
            // add fruits
            fruits.Add("apple");
            fruits.Add("banana");
            fruits.Add("orange");
            // now remove the banana
            fruits.Remove("banana");
            Console.WriteLine(fruits.Count);


            List<string> food = new List<string>();
            food.Add("apple");
            food.Add("banana");

            List<string> vegetables = new List<string>();
            vegetables.Add("tomato");
            vegetables.Add("carrot");

            food.AddRange(vegetables);
            Console.WriteLine(food.Count);

            string pause = Console.ReadLine(); // Just to pause
        }
    }
}
