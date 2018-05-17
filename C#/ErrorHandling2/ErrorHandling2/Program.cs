using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ErrorHandling2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 };
            int any = 0;

            try
            {
                for (int i = 0; i < 7; i++)
                {
                    any = numbers[i];
                }
              //  any = numbers[4];

            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Sorry, index out of range.");
            }
            Console.WriteLine("Continue");
        }//main
    }//program
}//namespace
