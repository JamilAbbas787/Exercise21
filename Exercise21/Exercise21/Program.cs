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
            string[] array = new string [] {};
            bool authorization;
            int arrayCount = 0;
            do
            {
                Console.Write("Would you like to enter another word (y/n)?    ");
                String continueEntering = Console.ReadLine();
                authorization = continueEntering.Equals("y", StringComparison.OrdinalIgnoreCase);
                if (authorization)
                {
                    Console.Write("Enter a word: ");
                    array[arrayCount] = Console.ReadLine();
                    
                    
                }

                arrayCount ++;
            } while (authorization);

            Console.Write($"{userInput}");
            //Console.Write($" {array}");
            foreach (var item in array)
            {
                Console.Write($" {array}");
            }
            Console.ReadKey();
        }
    }

}
