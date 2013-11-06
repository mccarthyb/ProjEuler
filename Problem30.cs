using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjEuler
{
    class Problem30
    {
        /*
            ProjectEuler problem 30:
            Surprisingly there are only three numbers that can be written as the sum of fourth powers of their digits:

                1634 = 1^4 + 6^4 + 3^4 + 4^4
                8208 = 8^4 + 2^4 + 0^4 + 8^4
                9474 = 9^4 + 4^4 + 7^4 + 4^4

            As 1 = 1^4 is not a sum it is not included.

            The sum of these numbers is 1634 + 8208 + 9474 = 19316.

            Find the sum of all the numbers that can be written as the sum of fifth powers of their digits.
         
            My Strategy for solving the problem:
            1. Calulate each digit 0-9 to the fifth power
            2. Find the upper limit of numbers i need to check to see if they are included in the sum/solution
            3. Step through numbers 2-UpperLimit to see if the sum of their fifth power digits equals the number
                 Add up fifth power digits of all digits
                 Check that sum vs original number
                 If they are equal, add it to the solution sum
            4. Solution sum should be calculated when all numbers up to upper limit have been checked
          */

        static void Main(string[] args)
        {
            //initialize array of values of 0-9 to the fifth power 
            int [] digitToFifth = new int[10];
            for (int x = 0; x < 10; x++)
               digitToFifth[x] = (int)Math.Pow(x, 5);
            

            int upperlimit = digitToFifth[9]*6;
            int sumOfDigits , digitCalc, solution = 0;

            /*  
                 calculating upper limit to check - 
                 9^5 is largest amount for a single digit
                 The highest sum of the 5th powers for 5 digits is 295,245 - needs to be more than 5 digits
                 The highest sum of the 5th powers for 6 digits is 354,294 - could possibly be 6, check 7 digits
                 The highest sum of the 5th powers for 7 digits is 413,343, so 7 digits can never be achieved
                 So we use the highest sum for 6 digits as the upper limit
             */

            Console.WriteLine("Finding solution to problem:");

            //going from 2 to upper limit to see if a specific number is a solution
            for (int x = 2; x < upperlimit; x++)
            {
           
          
                sumOfDigits = 0;
                digitCalc = x;
                //step through each digit and add up the sum of the digits
                while (digitCalc > 0)
                {
                    sumOfDigits = sumOfDigits + digitToFifth[(digitCalc%10)];
                    digitCalc = digitCalc / 10;

                }
                //add current number to solution sum if it is sum of digits is equal to the number
                if (sumOfDigits == x)
                {
                    Console.WriteLine("a solution: " + x);
                    solution = solution + x;
                }
            }
            Console.WriteLine("total sum solution: " + solution);
            

        }//end of main
    }
}
