using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[5];
            double sum = 0;
            double average;



            Console.WriteLine("Please enter 5 numbers to be averaged.");
           
            for (int i = 0; i < numbers.Length; i++)
            {
            Console.WriteLine("Please enter a number: ");
                numbers [i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            average = sum / numbers.Length;
            Console.WriteLine("The average is: " + average);

        }//main
    }//program
}//namespace
