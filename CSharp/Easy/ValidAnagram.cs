// Problem: Valid Anagram
// Link: https://leetcode.com/problems/valid-anagram/
//
// Task:
// Given two strings s and t, return true if t is an anagram of s, and false otherwise.

using System;
using System.Collections.Generic;

public class ValidAnagramSolutions
{
    // ------------------------------------------------------------
    // 🔹 Solution 1: Sorting
    // ------------------------------------------------------------
    // Idea:
    //   If two strings are anagrams, their sorted versions will be identical.
    //
    // Time Complexity: O(n log n)
    // Space Complexity: O(1) or O(n)
    // ------------------------------------------------------------
    public static bool IsAnagramSorting(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        char[] sArray = s.ToCharArray();
        char[] tArray = t.ToCharArray();

        Array.Sort(sArray);
        Array.Sort(tArray);

        return new string(sArray) == new string(tArray);
    }


    // ------------------------------------------------------------
    // ⚡ Solution 2: HashMap (Character Counting)
    // ------------------------------------------------------------
    // Idea:
    //   Count the frequency of each character in 's',
    //   then subtract counts for each character in 't'.
    //   If all counts return to zero, they are anagrams.
    //
    // Time Complexity: O(n)
    // Space Complexity: O(k), where k is the number of unique characters
    // ------------------------------------------------------------
    public static bool IsAnagramHashMap(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        Dictionary<char, int> count = new();

        // Count characters in s
        foreach (char c in s)
        {
            if (count.ContainsKey(c))
                count[c]++;
            else
                count[c] = 1;
        }

        // Subtract counts for t
        foreach (char c in t)
        {
            if (!count.ContainsKey(c))
                return false;

            count[c]--;
            if (count[c] < 0)
                return false;
        }

        return true;
    }


    // ------------------------------------------------------------
    // 🧪 Test Section
    // ------------------------------------------------------------
    public static void Main()
    {
        string[,] testCases = new string[,]
        {
            { "anagram", "nagaram" },
            { "rat", "car" },
            { "listen", "silent" },
            { "aacc", "ccac" }
        };

        for (int i = 0; i < testCases.GetLength(0); i++)
        {
            string s = testCases[i, 0];
            string t = testCases[i, 1];

            bool sortingResult = IsAnagramSorting(s, t);
            bool hashMapResult = IsAnagramHashMap(s, t);

            Console.WriteLine($"\"{s}\", \"{t}\" -> Sorting: {sortingResult}, HashMap: {hashMapResult}");
        }
    }
}
