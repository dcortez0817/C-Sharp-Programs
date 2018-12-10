/*Darien Cortez
 * 9/8/2018
 * This program allows the user to input 3 integers and finds the sum,
 * the average number, the largest number, and the smallest number. To make it 
 * easier to find the maximum and minimum values of the three, the code stores
 * and sorts the inputted numbers in an array.
 * */

//Namespace declaration
using System;

//Assignment2_Cortez namespace
namespace Assignment2_Cortez
{
    class Program
    {
        //Main program starts its excution proccess
        static void Main(string[] args)
        {
            bool y = true;
            while(y == true)
            {
                int i1, i2, i3, sum, avg, ans; //3 inputted integers

                //reads and converts the string values to integers
                Console.Write("Enter the first integer: ");
                i1 = Int32.Parse(Console.ReadLine());

                Console.Write("Enter the second integer: ");
                i2 = Int32.Parse(Console.ReadLine());

                Console.Write("Enter the third integer: ");
                i3 = Int32.Parse(Console.ReadLine());

                int[] myArray = new int[3] { i1, i2, i3 }; //stores values in array to make finding max in min value easier

                sum = i1 + i2 + i3; //adds all the integers together
                avg = sum / 3; //finds the average

                Array.Sort(myArray); //sorts the array

                Console.Write("\nSum = {0}", sum);
                Console.Write("\nAverage = {0}", avg);
                Console.Write("\nSmallest number = {0}", myArray[0]);
                Console.Write("\nLargest number = {0}\n", myArray[2]);

                Console.Write("\nWould you like to test 3 more integers? (enter 1 for yes and 2 for no)");
                ans = Int32.Parse(Console.ReadLine());
                if (ans == 1)
                    y = true;
                else
                    y = false;
            }
        }
    }
}
