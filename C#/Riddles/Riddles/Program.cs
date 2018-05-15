using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riddles
{
    class Program
    {
        static void Main(string[] args)
        {
            string correctAnswer = "an egg";
            string response = "";
            int numGuesses = 0;
            Console.WriteLine("I've got a riddle for you.");

            while (response != correctAnswer && numGuesses <3)
            {
                
                Console.WriteLine("What do you need to break before you use it?");

                response = Console.ReadLine();

                if (response == correctAnswer)
                {
                    Console.WriteLine("You got it!");
                    break;
                }
                else if (response != correctAnswer && numGuesses <=2)
                {
                    numGuesses++;
                    Console.WriteLine("Try again! You have 2 guesses left");
                }
                else if (response != correctAnswer && numGuesses <=1)
                {
                    numGuesses++;
                    Console.WriteLine("Try again! You have 1 guesses left");
                } else
                {
                    Console.WriteLine("Unlucky! Are you ready for your second riddle?");
                }
            }           

            

        } // main
    }// program
}// namespace
