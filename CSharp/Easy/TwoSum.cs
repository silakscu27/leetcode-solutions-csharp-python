// Problem: Two Sum
// Link: https://leetcode.com/problems/two-sum/
//
// Task:
// Given an integer array `nums` and an integer `target`,
// return indices of the two numbers such that they add up to `target`.
//
// Example:
// Input: nums = [2,7,11,15], target = 9
// Output: [0,1]

using System;
using System.Collections.Generic;

public class TwoSumSolutions
{
    // ------------------------------------------------------------
    // 🧩 Solution 1: Brute Force 
    // ------------------------------------------------------------
    // Time Complexity: O(n^2)
    // Space Complexity: O(1)
    // Explanation:
    //   Compare each pair of numbers and check if they sum to target.
    // ------------------------------------------------------------
    public static int[] TwoSumBruteForce(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                    return new int[] { i, j };
            }
        }
        return Array.Empty<int>();
    }


    // ------------------------------------------------------------
    // ⚡ Solution 2: HashMap 
    // ------------------------------------------------------------
    // Time Complexity: O(n)
    // Space Complexity: O(n)
    // Explanation:
    //   Use a dictionary to store numbers and their indices.
    //   For each number, check if (target - num) exists in the dictionary.
    // ------------------------------------------------------------
    public static int[] TwoSumHashMap(int[] nums, int target)
    {
        Dictionary<int, int> seen = new();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (seen.ContainsKey(complement))
                return new int[] { seen[complement], i };

            if (!seen.ContainsKey(nums[i]))
                seen[nums[i]] = i;
        }

        return Array.Empty<int>();
    }


    // ------------------------------------------------------------
    // 🧪 Test Section
    // ------------------------------------------------------------
    public static void Main()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        int[] result1 = TwoSumBruteForce(nums, target);
        int[] result2 = TwoSumHashMap(nums, target);

        Console.WriteLine("Brute Force: [" + string.Join(", ", result1) + "]");
        Console.WriteLine("HashMap: [" + string.Join(", ", result2) + "]");
    }
}
