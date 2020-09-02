/// Week No. 2	Lab No. 2
/// File Name: Program.cs
/// @author: Antonio Monteiro
/// Date:  September 1st, 2020

using System;

namespace Lab2
{
    class Program
    {

        //declare cost of prizes
        public const int CANDY_COST = 10;
        public const int GUMBALL_COST = 3;

        static void Main(string[] args)
        {

            //declare and determine amount of coupons
            int coupons;
            Console.WriteLine("How many coupons did you win? ");
            coupons = int.Parse(Console.ReadLine());

            //declare amount of gumballs and candy
            int numOfGumballs, numOfCandy;

            //determine how much candy you can buy
            numOfCandy = coupons / CANDY_COST;

            //remove coupons based on how many were bought
            coupons = coupons % CANDY_COST;

            //determine how many gumballs can be bought with remainder
            numOfGumballs = coupons / GUMBALL_COST;

            //tell the user how much they can buy
            Console.WriteLine("You can buy {0} candy bars and {1} gumballs.", numOfCandy, numOfGumballs);

            //Pause screen
            Console.ReadLine();

        }
    }
}
