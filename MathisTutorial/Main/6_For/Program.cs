using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_For
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("First loop Iteration: " + i);
            }

            for (int i = 0; i < 16; i++)
            {
                if (i == 12)
                {
                    break;
                }
                Console.WriteLine("Second loop Iteration: " + i);
            }


            for (int i = 0; i < 16; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }

                Console.WriteLine("Third loop Iteration: " + i);
            }

            string pause = Console.ReadLine(); // Just to pause
        }
    }
}
