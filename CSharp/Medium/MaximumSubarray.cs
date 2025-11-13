// Problem: Maximum Subarray
// Link: https://leetcode.com/problems/maximum-subarray/
//
// Task:
// Given an integer array `nums`, find the contiguous subarray
// (containing at least one number) that has the largest sum
// and return its sum.
//
// Example:
// Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
// Output: 6   (because [4,-1,2,1] has the largest sum = 6)

using System;

public class MaximumSubarray
{
    // ------------------------------------------------------------
    //  Solution: Kadane's Algorithm
    // ------------------------------------------------------------
    // Time Complexity: O(n)
    // Space Complexity: O(1)
    // Explanation:
    //   - Iterate through the array once
    //   - Keep track of the current subarray sum
    //   - If the current sum becomes smaller than the current element,
    //     start a new subarray from that element
    //   - Track the maximum sum seen so far
    // ------------------------------------------------------------
    public static int MaxSubArray(int[] nums)
    {
        if (nums == null || nums.Length == 0)
            return 0;

        int currentSum = nums[0];
        int maxSum = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            // Either add current element to the existing sum,
            // or start a new subarray from this element
            currentSum = Math.Max(nums[i], currentSum + nums[i]);

            // Update maxSum if currentSum is greater
            maxSum = Math.Max(maxSum, currentSum);
        }

        return maxSum;
    }

    // ------------------------------------------------------------
    //  Test Section
    // ------------------------------------------------------------
    public static void Main()
    {
        int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        Console.WriteLine("Maximum Subarray Sum: " + MaxSubArray(nums));
    }
}
