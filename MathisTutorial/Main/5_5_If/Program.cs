using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_5_If
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 2;
            int j = 2;

            if (i == j)
            {
                Console.WriteLine("First test: Values i and j are identical");
            }

            j = 3;
            if (i == j)
            {
                Console.WriteLine("Second test: Values i and j are identical");
            }
            else
            {
                Console.WriteLine("Second test: Values i and j are different");
            }

        }
    }
}
