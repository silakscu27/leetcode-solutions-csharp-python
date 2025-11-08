/*
Problem: Longest Substring Without Repeating Characters
Link: https://leetcode.com/problems/longest-substring-without-repeating-characters/

Task:
Given a string s, find the length of the longest substring without repeating characters.

Example:
Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with a length of 3.
*/

using System;
using System.Collections.Generic;

public class LongestSubstring
{
    public static int LengthOfLongestSubstring(string s)
    {
        HashSet<char> seen = new();
        int left = 0, maxLen = 0;

        for (int right = 0; right < s.Length; right++)
        {
            while (seen.Contains(s[right]))
            {
                seen.Remove(s[left]);
                left++;
            }

            seen.Add(s[right]);
            maxLen = Math.Max(maxLen, right - left + 1);
        }

        return maxLen;
    }

    // Test section
    public static void Main()
    {
        var testCases = new (string, int)[]
        {
            ("abcabcbb", 3),
            ("bbbbb", 1),
            ("pwwkew", 3),
            ("", 0),
            ("au", 2)
        };

        foreach (var (input, expected) in testCases)
        {
            int result = LengthOfLongestSubstring(input);
            Console.WriteLine($"Input: \"{input}\" → Output: {result} (Expected: {expected})");
        }
    }
}
