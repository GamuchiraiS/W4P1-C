using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = new int[10];
            //ask user to input numbers
            Console.WriteLine("Please enter 10  numbers: ");
            for (int i = 0; i < 10; i++)
            {
                //lets the user input the numbers
                Console.WriteLine("Element {0}: ", i);
                //converts the user input into type int and stores 
                //the numbers into an array
                numArr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Nums num = new Nums(numArr);
            num.Calculate_avg(num.numArr);
            Console.WriteLine("The average is: " + num.avg);
            int below = num.BelowAverage(num.numArr, num.avg);
            Console.WriteLine("Amount of numbers below the average: {0} ", below);
            int above = num.AboveAverage(num.numArr, num.avg);
            Console.WriteLine("Amount of numbers above the average: {0} ", above);
            Console.ReadLine();
        }
    }
}
