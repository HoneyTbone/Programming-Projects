/* Computer Science Project for Math 
Chapter 1 Question 2 in Cpmputer Science Projects
Tyson Toller
October 1st 2021 */

/* Takes an input of two strings and finds the 
AND, OR and XOR of the collective characters (includes spaces) */


using System;

public class Program
{

    public static void Main(string[] args)
    {

        // inputed strings from user
        string stringOne;
        string stringTwo;
        string or = "";
        string and = "";
        string xor = "";
        // stores temp values
        string resultOr = "";
        string resultAnd = "";
        string resultXor = "";

        Console.WriteLine("Compiles Two Integers To find bitwise 'OR' 'AND' and 'XOR'");

        ////////////////////////////////////////////////////////////////////////////////////
        // Input of String One
        Console.WriteLine("Input a string with 'n' characters to represent string one.");
        stringOne = Console.ReadLine();
        // Input of String Two
        Console.WriteLine("Input a string with 'n' characters to represent string two.");
        stringTwo = Console.ReadLine();

        // Stores the values of each character from stringOne and stringTwo
        char y;
        char z;

        // Prints the Strings to the console
        Console.WriteLine("String One is " + stringOne);
        Console.WriteLine("String Two is " + stringTwo);

        ////////////////////////////////////////////////////////////////////////////////////
        // Finds 'OR' for the Two Strings  
        for (int i = 0; i < stringOne.Length; i++) // adds the chars from stringOne
        {
            y = stringOne[i];
            resultOr = resultOr + y;
        }
        for (int i = 0; i < stringTwo.Length; i++) // adds the chars from stringTwo
        {

            z = stringTwo[i];
            resultOr = resultOr + z;
        }
        for (int i = 0; i < resultOr.Length; i++) // Removes duplicate chars
        {
            if (!or.Contains(resultOr[i]))
            {
                or += resultOr[i];
            }
        }
        Console.WriteLine("'OR' for the two strings is " + or);

        ////////////////////////////////////////////////////////////////////////////////////
        // Finds 'AND' for the Two Strings
        for (int i = 0; i < stringOne.Length; i++) // Checks all of stringOne
        {
            y = stringOne[i];
            for (int c = 0; c < stringTwo.Length; c++) // Checks all of stringTwo
            {
                z = stringTwo[c];
                if (y == z)
                {
                    // If char z = char y, we add it to temp 'AND'
                    resultAnd = resultAnd + z;
                }
            }
        }
        for (int i = 0; i < resultAnd.Length; i++) // Removes duplicate chars
        {
            if (!and.Contains(resultAnd[i]))
            {
                and += resultAnd[i];
            }
        }
        Console.WriteLine("'AND' for the two strings is " + and);
        ////////////////////////////////////////////////////////////////////////////////////

        // Prints the XOR for the Two Strings
        if (String.Equals(stringOne, stringTwo))
        {
            Console.WriteLine("'XOR' for the two strings is 'NO RESULT'! The two strings are the same.");
        }
        else
        {
            for (int i = 0; i < stringOne.Length; i++) // Checks stringTwo to stringOne
            {
                y = stringOne[i];
                if (stringTwo.Contains(y))
                {
                    /////////// Left blank on Purpose
                }
                else
                {
                    resultXor = resultXor + y;
                }
            }
            for (int i = 0; i < stringTwo.Length; i++) // Checks stringOne to stringTwo
            {
                z = stringTwo[i];
                if (stringOne.Contains(z))
                {
                    /////////// Left blank on Purpose
                }
                else
                {
                    resultXor = resultXor + z;
                }
            }
            for (int i = 0; i < resultXor.Length; i++) // Removes duplicate chars
            {
                if (!xor.Contains(resultXor[i]))
                {
                    xor += resultXor[i];
                }
            }

        }

        Console.WriteLine("'XOR' for the two strings is " + xor);
        /////////////////////////////////////////////////////////////////////////////

        Console.WriteLine("Duplicates of characters are removed.");
    }
}