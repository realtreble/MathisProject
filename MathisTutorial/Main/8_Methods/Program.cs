using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Methods
{
    class Program
    {
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            int x = 2;
            int y = 3;

            int result = Multiply(x, y);
            Console.WriteLine("Result:" + result);

            string pause = Console.ReadLine(); // Just to pause
        }
    }
}
