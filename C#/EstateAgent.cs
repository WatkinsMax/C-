using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousesObjectsAndFields
{
    public class House
    {
        //create a blueprint for a house object
        //non-static or instance fields
        public string address = "";
        public int numberOfBedrooms = 0;
        public int price = 0;

        //static field
        public static int housesForSale = 0;

    }
    class Program
    {
        static void Main(string[] args)
        {
            //initialise the static variable
            House.housesForSale = 0;

            //instantiate house objects and give values to their fields, 
            //incrementing the static variable each time a house is added
            House house1 = new House();
            house1.address = "23 Railway Cuttings, East Cheam";
            house1.numberOfBedrooms = 1;
            house1.price = 150000;

            House.housesForSale++;

            House house2 = new House();
            house2.address = "4 Privet Drive, Little Whinging, Surrey";
            house2.numberOfBedrooms = 4;
            house2.price = 750000;

            House.housesForSale++;

            House house3 = new House();
            house3.address = "Flat 368, Nelson Mandela House, Dockside Estate, Peckham";
            house3.numberOfBedrooms = 3;
            house3.price = 250000;

            House.housesForSale++;

            //display the details of the houses
            Console.WriteLine("These are the details of the houses on our books:");
            Console.WriteLine();
            Console.WriteLine(house1.address + "\nNo. bedrooms: " + house1.numberOfBedrooms + "\nPrice: " + house1.price);
            Console.WriteLine();
            Console.WriteLine(house2.address + "\nNo. bedrooms: " + house2.numberOfBedrooms + "\nPrice: " + house2.price);
            Console.WriteLine();
            Console.WriteLine(house3.address + "\nNo. bedrooms: " + house3.numberOfBedrooms + "\nPrice: " + house3.price);

            //display the total number for sale
            Console.WriteLine();
            Console.WriteLine("The total number of houses for sale is: " + House.housesForSale);
        }
    }
}