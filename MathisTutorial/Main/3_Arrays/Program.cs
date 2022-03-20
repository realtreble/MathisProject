using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            Console.WriteLine(nums.Length);

            int[] nums2 = new int[10];
            int firstNumber = nums2[0];
            int secondNumber = nums2[1];
            nums2[2] = 10;
            Console.WriteLine(nums2.Length);
            Console.WriteLine(nums2[2]);

            int[,] predefinedMatrix = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            Console.WriteLine(predefinedMatrix[1, 1]);

            int[,] matrix = new int[2, 2];
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[1, 0] = 3;
            matrix[1, 1] = 4;
            Console.WriteLine(matrix[0,0]);

            string pause = Console.ReadLine(); // Just to pause
        }
    }
}
