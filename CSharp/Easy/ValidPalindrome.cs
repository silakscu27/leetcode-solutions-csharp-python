// Problem: Valid Palindrome
// Link: https://leetcode.com/problems/valid-palindrome/
//
// Task:
// Given a string s, determine if it is a palindrome,
// considering only alphanumeric characters and ignoring cases.

using System;
using System.Text;

public class ValidPalindromeSolution
{
    // ------------------------------------------------------------
    // ⚡ Solution: Two-Pointer Technique
    // ------------------------------------------------------------
    // Time Complexity: O(n)
    // Space Complexity: O(1)
    // ------------------------------------------------------------
    public static bool IsPalindrome(string s)
    {
        StringBuilder filtered = new();

        foreach (char c in s)
        {
            if (char.IsLetterOrDigit(c))
                filtered.Append(char.ToLower(c));
        }

        int left = 0;
        int right = filtered.Length - 1;

        while (left < right)
        {
            if (filtered[left] != filtered[right])
                return false;
            left++;
            right--;
        }

        return true;
    }


    // ------------------------------------------------------------
    // 🧪 Test Section
    // ------------------------------------------------------------
    public static void Main()
    {
        string[] testCases =
        {
            "A man, a plan, a canal: Panama",
            "race a car",
            " ",
            "No lemon, no melon"
        };

        foreach (var test in testCases)
        {
            Console.WriteLine($"\"{test}\" -> {IsPalindrome(test)}");
        }
    }
}
