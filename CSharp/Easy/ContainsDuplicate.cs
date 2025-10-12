// Problem: Contains Duplicate
// Link: https://leetcode.com/problems/contains-duplicate/
//
// Task:
// Given an integer array nums, return true if any value appears at least twice
// in the array, and false if every element is distinct.

using System;
using System.Collections.Generic;

public class ContainsDuplicateSolutions
{
    // ------------------------------------------------------------
    // ⚡ Solution 1: HashSet
    // ------------------------------------------------------------
    // Idea:
    //   Use a HashSet to store numbers as we iterate through the array.
    //   If a number already exists in the set, we found a duplicate.
    //
    // Time Complexity: O(n)
    // Space Complexity: O(n)
    // ------------------------------------------------------------
    public static bool ContainsDuplicate_HashSet(int[] nums)
    {
        HashSet<int> seen = new();

        foreach (int num in nums)
        {
            if (seen.Contains(num))
                return true;  // Duplicate found

            seen.Add(num);
        }

        return false; // No duplicates
    }


    // ------------------------------------------------------------
    // 🔸 Solution 2: Sorting
    // ------------------------------------------------------------
    // Idea:
    //   Sort the array and check if any two consecutive elements are equal.
    //
    // Time Complexity: O(n log n)
    // Space Complexity: O(1) or O(n) depending on sort implementation
    // ------------------------------------------------------------
    public static bool ContainsDuplicate_Sorting(int[] nums)
    {
        Array.Sort(nums);

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1])
                return true;
        }

        return false;
    }


    // ------------------------------------------------------------
    // 🧪 Test Section
    // ------------------------------------------------------------
    public static void Main()
    {
        int[][] testCases = new int[][]
        {
            new int[] { 1, 2, 3, 1 },
            new int[] { 1, 2, 3, 4 },
            new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 },
            new int[] { },
            new int[] { 0 }
        };

        foreach (int[] nums in testCases)
        {
            bool resultHashSet = ContainsDuplicate_HashSet(nums);
            bool resultSorting = ContainsDuplicate_Sorting((int[])nums.Clone());

            Console.WriteLine($"[{string.Join(", ", nums)}] -> HashSet: {resultHashSet}, Sorting: {resultSorting}");
        }
    }
}
