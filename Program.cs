//Assignment 3-1-3
//Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string.

using System.ComponentModel;

namespace CCAD16_Assignment3_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a sentence with spaces.");
            string userInput = Console.ReadLine();

            int charCount = CountSpaces(userInput);

            Console.WriteLine($"The number of spaces in the string is: {charCount}");
        }

        static int CountSpaces(string input)
        {
            int count = 0;
            foreach (char c in input) 
            {
                if (c == ' ')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
