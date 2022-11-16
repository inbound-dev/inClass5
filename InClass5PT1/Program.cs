using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass5PT1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            String userInput;
            List<String> output = new List<String>();

            // ask user for input
            Console.WriteLine("In one word Please enter your first and Last Name!");
            userInput = Console.ReadLine();

            //flips the input string
            for (int i = userInput.Length-1; i >= 0; i--)
            {
                output.Add((userInput[i].ToString()));
            }

            //prints the output
            for (int i = 0; i <= output.Count-1;i++)
            {
                Console.Write(output[i]);
            }
            
            //exit menu
            Console.WriteLine("");
            Console.WriteLine("Press Any Key to Escape!");
            Console.ReadKey();
        }
    }
}
