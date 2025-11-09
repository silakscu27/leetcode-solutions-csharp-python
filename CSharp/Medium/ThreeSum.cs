/*
Problem: 3Sum
Link: https://leetcode.com/problems/3sum/

Task:
Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]]
such that i != j, i != k, j != k, and nums[i] + nums[j] + nums[k] == 0.

The solution set must not contain duplicate triplets.

Example:
Input: nums = [-1, 0, 1, 2, -1, -4]
Output: [[-1, -1, 2], [-1, 0, 1]]
*/

using System;
using System.Collections.Generic;

public class ThreeSumSolution
{
    public static IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        var result = new List<IList<int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            // Skip duplicates for i
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                int total = nums[i] + nums[left] + nums[right];

                if (total == 0)
                {
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });
                    left++;
                    right--;

                    // Skip duplicate values for left
                    while (left < right && nums[left] == nums[left - 1])
                        left++;

                    // Skip duplicate values for right
                    while (left < right && nums[right] == nums[right + 1])
                        right--;
                }
                else if (total < 0)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }

        return result;
    }

    // Test section
    public static void Main()
    {
        int[] nums = { -1, 0, 1, 2, -1, -4 };
        var result = ThreeSum(nums);

        Console.WriteLine("Input: [" + string.Join(", ", nums) + "]");
        Console.WriteLine("Output:");
        foreach (var triplet in result)
        {
            Console.WriteLine("[" + string.Join(", ", triplet) + "]");
        }
    }
}
