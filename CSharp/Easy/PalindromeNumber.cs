// Problem: Palindrome Number
// Link: https://leetcode.com/problems/palindrome-number/
//
// Task:
// Given an integer `x`, return true if `x` is a palindrome, otherwise return false.
// A palindrome number reads the same backward as forward.
//
// Example:
// Input: 121
// Output: true
//
// Example:
// Input: -121
// Output: false
// Explanation: From right to left it becomes 121-, which is not the same.

using System;

public class PalindromeNumberSolutions
{
    // ------------------------------------------------------------
    // Solution 1: Convert to string
    // ------------------------------------------------------------
    // Time Complexity: O(n)
    // Space Complexity: O(n)
    // Explanation:
    //   Convert number to string and check if it equals its reverse.
    // ------------------------------------------------------------
    public static bool IsPalindromeString(int x)
    {
        string s = x.ToString();
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        string reversed = new string(arr);

        return s == reversed;
    }


    // ------------------------------------------------------------
    // 🧪 Test Section
    // ------------------------------------------------------------
    public static void Main()
    {
        int[] tests = { 121, -121, 10, 12321, 0 };

        foreach (var n in tests)
        {
            Console.WriteLine($"{n} -> string method: {IsPalindromeString(n)}");
        }
    }
}
