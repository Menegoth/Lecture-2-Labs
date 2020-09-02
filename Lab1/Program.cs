/// Week No. 2	Lab No. 1
/// File Name: Program.cs
/// @author: Antonio Monteiro
/// Date:  September 1st, 2020

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MyFirstProgram
    {
        static void Main(string[] args)
        {
            // print a message to the screen
            Console.WriteLine("Hello out there.");
            Console.WriteLine("I will do some math for you");
            Console.WriteLine("Enter a number and press enter for each three times:");

            // declare three integer variables and their math results
            int n1, n2, n3;
            int sum, product, quotient;

            //Get user data for all 3 numbers
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());

            // calculate the sum of these three numbers
            sum = n1 + n2 + n3;

            // print a message along with the sum of the two numbers
            Console.WriteLine("The sum of those three numbers is: {0}\n", sum);

            //Mulitply the 3 and print result
            product = n1 * n2 * n3;
            Console.WriteLine("The product of those three numbers is: {0}\n", product);

            //divide the sum by product
            quotient = sum / product;
            Console.WriteLine("The sum divided by the product is: {0}\n", quotient);

            //Just to pause the screen.
            Console.ReadLine();

        }
    }
}