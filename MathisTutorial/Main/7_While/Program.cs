using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            while (n <= 6)
            {
                Console.WriteLine("N is :" + n);
                n++;
            }

            string pause = Console.ReadLine(); // Just to pause
        }
    }
}
