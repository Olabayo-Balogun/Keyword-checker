using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_four_task_three
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to wordchecker");
            Console.WriteLine("Hello! input your word");
            string wordInput = Console.ReadLine();
            string firstInitiator = "s";
            string secondInitiator = "a";
            string firstExemption = "e";
            string secondExemption = "m";

            if ((wordInput.Contains(firstInitiator)) && (wordInput.Contains(secondInitiator)) && (wordInput.Contains(firstExemption)) && (wordInput.Contains(secondExemption)))
            {
                int result = (wordInput.Count()) - (firstInitiator.Count()) - (secondInitiator.Count()) - (firstExemption.Count()) - (secondExemption.Count());
                Console.WriteLine($"You have {result} number of letters in your word. Great job!");
            }

            else if ((wordInput.Contains(firstInitiator)) && (wordInput.Contains(secondInitiator)))
            {
                int result = (wordInput.Count()) - (firstInitiator.Count()) - (secondInitiator.Count()) - (firstExemption.Count()) - (secondExemption.Count());
                Console.WriteLine($"You have {result} number of letters in your word. Great job!");
            }

            else if ((wordInput.Contains(firstInitiator)) && (wordInput.Contains(secondInitiator)) && (wordInput.Contains(firstExemption)))
            {
                int result = (wordInput.Count()) - (firstInitiator.Count()) - (secondInitiator.Count()) - (firstExemption.Count());
                Console.WriteLine($"You have {result} number of letters in your word. Great job!");
            }

            else if ((wordInput.Contains(firstInitiator)) && (wordInput.Contains(secondInitiator)) && (wordInput.Contains(secondExemption)))
            {
                int result = (wordInput.Count()) - (firstInitiator.Count()) - (secondInitiator.Count()) - (secondExemption.Count());
                Console.WriteLine($"You have {result} number of letters in your word. Great job!");
            }

            else if ((!wordInput.Contains(firstInitiator)) || (!wordInput.Contains(secondInitiator)))
            {
                Console.WriteLine("Cool word, we however won't run analysis on it as it doesn't possess the required parameters \n Would you like to know our parameters?");
                string response = Console.ReadLine();
                if (response == "yes")
                {
                    Console.WriteLine("Cool word, we however won't run analysis on it as it doesn't possess the required parameters \n Would you like to know our parameters?");
                }
            }
            Console.ReadLine();
        }
    }
}
