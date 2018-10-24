using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise21
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a word: \t");
            string userInput = Console.ReadLine();
            string[] array = new string [1];
            bool authorization = true;
            int arrayCount = 0;

            while(authorization)
            {
                Console.Write("Would you like to enter another word (y/n)?    ");
                String continueEntering = Console.ReadLine();
                authorization = continueEntering.Equals("y", StringComparison.OrdinalIgnoreCase);
                if (authorization)
                {
                    Console.Write("Enter a word: ");
                    array[arrayCount] = Console.ReadLine();
                    Array.Resize(ref array, array.Length + 1);
                    arrayCount++;
                }               
            }

            Console.Write($"{userInput} ");
            foreach (var item in array)
            {
                Console.Write(item + " ");            
            }
            Console.ReadKey();
        }
    }

}
