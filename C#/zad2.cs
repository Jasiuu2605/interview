using System;

namespace PalindromeChecker
{
    class Zad2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();

            // Check if the string is a palindrome
            bool isPalindrome = IsPalindrome(input);

            // Print the result
            Console.WriteLine(isPalindrome ? "YES" : "NO");
        }

        static bool IsPalindrome(string input)
        {
            int length = input.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (char.ToLower(input[i]) != char.ToLower(input[length - i - 1]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}