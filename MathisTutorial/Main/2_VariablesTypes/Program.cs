using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_VariablesTypes
{
    class Program
    {
        public enum CarType
        {
            Toyota = 1,
            Honda = 2,
            Ford = 3,
        }

        static void Main(string[] args)
        {
            int myInt = 1;
            float myFloat = 1f;
            bool myBoolean = true;
            string myName = "John";
            char myChar = 'a';

            int x = 1;
            int y = 2;
            int sum = x + y;

            CarType myCarType = CarType.Toyota;

            Console.WriteLine("Int: " + myInt);
            Console.WriteLine("Float: " + myFloat);
            Console.WriteLine("Bool: " + myBoolean);
            Console.WriteLine("Name: " + myName);
            Console.WriteLine("Char: " + myChar);
            Console.WriteLine("sum: " + sum);
            Console.WriteLine("CarType: " + myCarType);

            string pause = Console.ReadLine(); // Just to pause
        }
    }
}
