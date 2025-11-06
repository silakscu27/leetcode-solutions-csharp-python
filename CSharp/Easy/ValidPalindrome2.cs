/*
Problem: Valid Palindrome II
Link: https://leetcode.com/problems/valid-palindrome-ii/

Task:
Given a string `s`, return true if the string can be a palindrome 
after deleting at most one character.

Example:
Input: s = "abca"
Output: true
Explanation: Deleting 'b' or 'c' results in "aba" or "aca", both are palindromes.
*/

using System;

public class ValidPalindromeII
{
    // ------------------------------------------------------------
    //  Helper Function: Check Palindrome in Range
    // ------------------------------------------------------------
    //   Checks if substring between two indices is palindrome.
    // ------------------------------------------------------------
    private static bool IsPalindromeRange(string s, int left, int right)
    {
        while (left < right)
        {
            if (s[left] != s[right])
                return false;

            left++;
            right--;
        }
        return true;
    }


    // ------------------------------------------------------------
    //  Solution: Two Pointers + One Deletion Allowed
    // ------------------------------------------------------------
    // Time Complexity: O(n)
    // Space Complexity: O(1)
    // Explanation:
    //   Use two pointers from both ends.
    //   If mismatch occurs, try skipping one character (either left or right).
    //   If either substring is palindrome → return true.
    // ------------------------------------------------------------
    public static bool ValidPalindrome(string s)
    {
        int left = 0, right = s.Length - 1;

        while (left < right)
        {
            if (s[left] != s[right])
            {
                // Try removing one character from left or right
                return IsPalindromeRange(s, left + 1, right) || IsPalindromeRange(s, left, right - 1);
            }

            left++;
            right--;
        }

        return true;
    }
}


// ------------------------------------------------------------
//   Test Section
// ------------------------------------------------------------
public class Program
{
    public static void Main(string[] args)
    {
        var testCases = new (string Input, bool Expected)[]
        {
            ("aba", true),
            ("abca", true),
            ("abc", false),
            ("deeee", true),
            ("cbbcc", true)
        };

        foreach (var (input, expected) in testCases)
        {
            bool result = ValidPalindromeII.ValidPalindrome(input);
            Console.WriteLine($"Input: \"{input}\" → Output: {result} | Expected: {expected}");
        }
    }
}
