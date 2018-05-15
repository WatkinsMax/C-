using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();

            int myNumber = rnd.Next(1, 50);

            int response = 0;


            do
            {
                Console.WriteLine("I'm thinking of a number. Try and guess it...");

                response = Convert.ToInt32(Console.ReadLine());

                if (response == myNumber)
                {
                    Console.WriteLine("Correct!");
                }
                else if (response > myNumber)
                {
                    Console.WriteLine("The number I'm thinking of is smaller than that number");
                }
                else
                {
                    Console.WriteLine("The number I'm thinking of is bigger than that number");
                }

            } while (response != myNumber);
      
        }//main
    }//class
}//namspace