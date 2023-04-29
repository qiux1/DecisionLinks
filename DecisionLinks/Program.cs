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

    //use memorization to store the calculated factorials of input numbers
    private static Dictionary<int, long> factorialMemory= new Dictionary<int, long>();
    /// <summary>
    /// Method to find the Fibonacci number of the input number provided
    /// if the input is negative, it will return null
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public static long Factorial(int num)
    {
        //if the input number is 0 return 1
        if (num == 0)
        {
            return 1;
        }
        // for negative input: if odd, return negative factorial of absolute input value.
        // if even, return factorial of absolute input value.
        else if (num < 0) 
        { 
            return (num % 2 == 0 ? 1 : -1)* Factorial(Math.Abs(num));
        }
        else
        {
            //if the input number is previous calculate before
            //just retrive the number from the dictionary instead of calculating it again
            if (factorialMemory.ContainsKey(num))
            {
                return factorialMemory[num];
            }

            //calculate the num factorial by using recurssion
            long factorial = num * Factorial(num - 1);

            //if the number is not stored in the dictionary
            //add it into the dictionary
            if (!factorialMemory.ContainsKey(num))
            {
                factorialMemory[num] = factorial;
            }

            return factorial;
        }

    }

    /// <summary>
    /// Method to check if the input string is Palidrome or not
    /// This method take into the consideraion of uppercase 
    /// lowercase, special characters, numbers, and whitespace
    /// it will return true if input meets all conditions
    /// else return false
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsPalidrome(string input)
    {
        //it is false if the input value is null
        if (input == null)
        {
            return false;
        }
       
    }

    public static void Main(string[] args)
    {
        //testing code for FindFistNonRepeatingCharacter method
        Console.WriteLine("Please Enter a word");
        string input = Console.ReadLine();
        char? NonRepeatingChar = FindFistNonRepeatingCharacter(input); 
        if (NonRepeatingChar == null) 
        {
            Console.WriteLine("There is no repeating character");
        }
        Console.WriteLine(NonRepeatingChar);

        //Teseting code Factorial method
        Console.WriteLine(Factorial(0));
        Console.WriteLine(Factorial(1));
        Console.WriteLine(Factorial(-5));
        Console.WriteLine(Factorial(7));
        Console.WriteLine(Factorial(-10));
        Console.WriteLine(Factorial(12));
    }
}