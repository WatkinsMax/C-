using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfBooks = new List<string>() { "The Hunger Games", "Catching Fire", "Mockingjay" };

    

            Console.WriteLine("Here is your book collection. \nTo add a book, press A. To exit, press X:");
            string answer = (Console.ReadLine());

            string Add = "a";
            string Exit = "x";
            string reply = "";


            while (answer != Exit)
            {
                Console.WriteLine("Type the name of the book you would like to add: ");
                reply = Console.ReadLine();
                listOfBooks.Add(reply);
                Console.WriteLine("Would you like to add another book? \nTo add another book, press A. To exit, press X");
                reply = Console.ReadLine();
 
            } 


           //if (answer == Exit)
           //      Console.WriteLine("Your current list of books: ");
           // {
              foreach (string displayList in listOfBooks)
                {
                    Console.WriteLine(displayList);
                }
                
            
        }//main
    }//program
}//namespace

 