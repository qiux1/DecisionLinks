﻿using System;
using System.Collections.Generic;
class Program
{
    /// <summary>
    /// A method to find the first non-repeating character in a provided string
    /// return null if the input does not have a non-repeating character
    /// else return the first non-repeating character
    /// S:O(N) T:O(N)
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static char? FindFirstNonRepeatingCharacter(string input)
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
    /// T:O(n) S:O(N)
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
    /// This method take into the consideration uppercase 
    /// lowercase, special characters, numbers, and whitespace
    /// it will return true if input meets all conditions
    /// else return false
    /// T:O(N) S:O(1)
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
        //intitalize a left and right pointer to check the input
        int left = 0;
        int right = input.Length - 1;

        //while loop as long as left is less than right
        while (left < right)
        {
            //comapre the chracters at the left pointer and right pointer
            //return false it is different
            if (input[left] != input[right])
            {
                return false;
            }

            //increment left pointer by 1 and reduce right pointer by 1
            left++;
            right--;
        }
        return true;
    }
    /// <summary>
    /// Implement Binary Search method to find the target integer
    /// from an array of integer provided
    /// return the index of the target value if it is in input array
    /// else return -1
    /// TLO(logn) S:O(1)
    /// </summary>
    /// <param name="input"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static int BinarySearch(int[] nums, int target)
    {
        //initialize left and right pointer
        int left = 0;
        int right = nums.Length - 1;

        //while loop to iterate through the nums array as long as left is less equal than right pointer
        while (left <= right)
        {
            //find the middle index between left and right pointer
            int middle = left + (right - left)/2;
            //if the value at the middle index is equal to target value
            //return the index value to middle
            if (nums[middle] == target)
            {
                return middle;
            }
            //if the value at middle index is less than target value
            else if (nums[middle] < target) 
            {
                //update the left pointer to be middle + 1
                left = middle + 1;
            }
            //if the value at middle index is greater than target value
            else
            {
                //update the right pointer to the middle - 1
                right = middle - 1;
            }
        }

        //if cannot find the target in the nums array, return -1
        return -1;
    }

    public static void Main(string[] args)
    {
        //testing code for FindFistNonRepeatingCharacter method
        Console.WriteLine("Please Enter a word");
        string input = Console.ReadLine();
        char? NonRepeatingChar = FindFirstNonRepeatingCharacter(input); 
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

        //Testing code IsPalidrome method
        Console.WriteLine(IsPalidrome(null)+ "is False" );
        Console.WriteLine(IsPalidrome("asdfgfdsa")+ " is True");
        Console.WriteLine(IsPalidrome("asdfg fdsa") + " is False");
        Console.WriteLine(IsPalidrome("asdf g fdsa") + " is True");
        Console.WriteLine(IsPalidrome("asdf g f1dsa") + " is False");
        Console.WriteLine(IsPalidrome("1asdf g fdsa1")+ " is True");
        Console.WriteLine(IsPalidrome("as3df g fd1sa") + " is False");
        Console.WriteLine(IsPalidrome("!as df g fd sa") + " is False");
        Console.WriteLine(IsPalidrome("!a2s df g fd s2a!") + " is True");
        Console.WriteLine(IsPalidrome("!a2s df gg fd s2a!") + " is True");
        Console.WriteLine(IsPalidrome("!a2s df g@g fd s2a!") + " is True");
        Console.WriteLine(IsPalidrome("!a2s df g@g fd s2b!") + " is False");
        Console.WriteLine(IsPalidrome(" !a2s df g@g fd s2a! ") + " is True");

        //Testing code BinarySearch method
        int[] nums1 = { 1, 2, 3, 5, 6, 7, 8, 10, 11 };
        Console.WriteLine(BinarySearch(nums1, 0));
        Console.WriteLine(BinarySearch(nums1, 1));
        Console.WriteLine(BinarySearch(nums1, 4));
        Console.WriteLine(BinarySearch(nums1, 5));
        Console.WriteLine(BinarySearch(nums1, 9));
        Console.WriteLine(BinarySearch(nums1, 11));
        Console.WriteLine(BinarySearch(nums1, 20));
    }
}