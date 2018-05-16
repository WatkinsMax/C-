using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {

        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            char signChosen;
            decimal result = 0;


            Console.WriteLine("This program will do simple arithmatic for you if you enter two numbers and a sign. \n( + - * / )");
            Console.WriteLine("Please enter the first number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the sign: ");
            signChosen = Convert.ToChar(Console.ReadLine());
            if (signChosen != "+", "-", "*", "/") 
            {
                Console.WriteLine("Please enter a valid sign");
            } else {

                Console.WriteLine("And finally, please selected the second number: ");
                secondNumber = Convert.ToInt32(Console.ReadLine());
            }

            switch (signChosen)
            {
                case '+':
                result = AddNumbers(firstNumber, secondNumber);
                    break;
                case '-':
                    result = SubtractNumbers(firstNumber, secondNumber);
                    break;
                case '*':
                    result = MultiplyNumbers(firstNumber, secondNumber);
                    break;
                case '/':
                    result = DivideNumbers(firstNumber, secondNumber);
                    break;
             }

            Console.WriteLine("The answer is: " + result);

        }//main

        static decimal AddNumbers(int first, int second)
        {
            decimal result = (first + second);
            return result;

        }
        static decimal SubtractNumbers(int first, int second)
        {
            decimal result = (first - second);
            return result;

        }
        static decimal MultiplyNumbers(int first, int second)
        {
            decimal result = (first * second);
            return result;

        }
        static decimal DivideNumbers(int first, int second)
        {
            decimal result = (first / second);
            return result;

        }//AddNumbers

    }//program
}//namespace
