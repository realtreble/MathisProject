using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string emptyString = String.Empty;
            string anotherEmptyString = "";
            Console.WriteLine("Nothing->" + anotherEmptyString);

            string firstName = "Eric";
            string lastName = "Smith";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            string sentence = "I like to play ";
            sentence += "chess.";
            Console.WriteLine(sentence);

            int x = 1, y = 2;
            int sum = x + y;
            string sumCalculation = String.Format("{0} + {1} = {2}", x, y, sum);
            Console.WriteLine(sumCalculation);

            string fullString = "full string";
            string partOfString = fullString.Substring(5);
            string shorterPart = fullString.Substring(5, 3);
            Console.WriteLine(partOfString);
            Console.WriteLine(shorterPart);

            string name = "John Doe";
            string newName = name.Replace("John", "Eric");
            Console.WriteLine(newName);


            string fruit = "apple,orange,banana";
            Console.WriteLine("Found orange in position: " + fruit.IndexOf("orange"));
            Console.WriteLine("Found lemon in position: " + fruit.IndexOf("lemon"));


            string pause = Console.ReadLine(); // Just to pause
        }
    }
}
