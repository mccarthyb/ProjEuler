using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Proj89
{
    class Project89
    {
        /*
           The rules for writing Roman numerals allow for many ways of writing each number (see About Roman Numerals...). 
           However, there is always a "best" way of writing a particular number.
           
           The 11K text file, roman.txt (right click and 'Save Link/Target As...'), contains one thousand numbers written in valid, but not necessarily minimal, Roman numerals; 
           that is, they are arranged in descending units and obey the subtractive pair rule (see About Roman Numerals... for the definitive rules for this problem).

           Find the number of characters saved by writing each of these in their minimal form.

           Note: You can assume that all the Roman numerals in the file contain no more than four consecutive identical units.
          
           Strategy for finding solution: Find strings that can be reduced to minimal roman numerals using RegEx (which the reduced form will always be 2 characters)
           Then replace these characters and find the difference in the length of the original string vs the one that has been reduced
         */
        static void Main(string[] args)
        {

            string roman = System.IO.File.ReadAllText(@"C:\prog\roman.txt"), newRoman;
            int solution;

            string pattern = "(IIII|VIIII|CCCC|DCCCC|XXXX|LXXXX)";

            newRoman = Regex.Replace(roman, pattern, "pp");

            solution = roman.Length - newRoman.Length;

            Console.WriteLine("The minimal form is " + solution + " less characters");


        }// end of main


        
    }
}
