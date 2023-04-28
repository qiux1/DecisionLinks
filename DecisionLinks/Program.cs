using System;
using System.Collections.Generic;
class Program
{
    /// <summary>
    /// A method to find the first non-repeating character in a provided string
    /// return null if the input does not have a non-repeating character
    /// else return the first non-repeating character
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static char? FindFistNonRepeatingCharacter(string input)
    {
        //use dictonary to store the frequence of each character from input string
        Dictionary<char, int> map = new Dictionary<char, int>();

        //iterate through the input string using foreach 
        foreach(char c in input)
        {
            //if the map already contains the character
            if (map.ContainsKey(c))
            {
                //increment the value by 1
                map[c]++;
            }
            else
            {
                //if the map does not contain the character,
                //add the <c, 1> into the map dictionary
                map.Add(c, 1);
            }
        }

        //foreach to iterate through input string again to find the first non-repeating character
        foreach(char c in input)
        {
            //if this character value in the map is 1,
            //it is the first non-repeating character
            if (map[c] == 1)
            {
                //return the character
                return c;
            }

        }
        //if there is no non-repeating character from input string
        return null;
    }

    /// <summary>
    /// Method to find the Fibonacci number of the input number provided
    /// if the input is negative, it will return null
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public static long? Factorial(int num)
    {
        //if the input number is 0, return 1
        if (num == 0)
        {
            return 1;
        }
        //if the input is positive number
        else if (num >1) 
        {
            //initiate the first fibonacci number which is 1
            long fibonacci = 1;
            //use for loop to calculate the fibonacci number
            for (int i = 1; i <= num; i++)
            {
                //fibonacci number is 
                fibonacci *= i;
            }
            return fibonacci;
        }
        return null;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Please Enter a word");
        string input = Console.ReadLine();
        char? NonRepeatingChar = FindFistNonRepeatingCharacter(input); 
        if (NonRepeatingChar == null) 
        {
            Console.WriteLine("There is no repeating character");
        }
        Console.WriteLine(NonRepeatingChar);
    }
}