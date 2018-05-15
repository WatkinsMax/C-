using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string reply = "";

            Console.WriteLine("Ronaldo, Messi & Neymar are all nominated for the Ballon D'or. Who do you think should win it?");

            string winner = (Console.ReadLine()).ToLower();

            switch (winner)
            {
                case "ronaldo":
                    reply = "I'd agree!";
                    break;
                case  "messi":
                    reply = "This year? Really???";
                    break;
                case  "neymar":
                    reply = "The dark horse!";
                    break;
                default:
                    reply = "Who?! I don't think so";
                    break;
            }

            Console.WriteLine(reply);
        }// main
    }// program
}// namespace
