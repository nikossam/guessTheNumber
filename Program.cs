using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int guessingNumber;
            int userInput;
            bool guessTheNumber = true;

            guessingNumber =  rnd.Next(1,100);

            while (guessTheNumber)
            {
                Console.WriteLine("Guess the number: ");
                userInput = Convert.ToInt32(Console.ReadLine());

                if(userInput > guessingNumber)
                {
                    Console.WriteLine("Hide number is lower.");
                }
                else if(userInput < guessingNumber)
                {
                    Console.WriteLine("Hide number is higher.");
                }            
                else
                {
                    Console.WriteLine("Congratulation!You find it!");
                    guessTheNumber = false;
                }

                

            }
            Console.ReadKey();




        }
    }
}
