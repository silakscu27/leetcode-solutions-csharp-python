// Problem: Maximum Product Subarray
// Link: https://leetcode.com/problems/maximum-product-subarray/
//
// Task:
// Given an integer array nums, find the contiguous subarray within the array
// (containing at least one number) which has the largest product.
//
// Example:
// Input: nums = [2,3,-2,4]
// Output: 6
// Explanation: The subarray [2,3] has the largest product 6.

using System;

public class MaximumProductSubarray
{
    // ------------------------------------------------------------
    // Approach: Track max and min products dynamically
    // ------------------------------------------------------------
    // 1. Maintain both max and min products at each index.
    // 2. Swap max and min when a negative number is encountered.
    // 3. Update global maximum at each step.
    // Time Complexity: O(n)
    // Space Complexity: O(1)
    // ------------------------------------------------------------
    public static int MaxProduct(int[] nums)
    {
        if (nums == null || nums.Length == 0)
            return 0;

        int maxProd = nums[0];
        int minProd = nums[0];
        int result = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            int num = nums[i];

            if (num < 0)
            {
                // Swap max and min when negative number is found
                int temp = maxProd;
                maxProd = minProd;
                minProd = temp;
            }

            maxProd = Math.Max(num, num * maxProd);
            minProd = Math.Min(num, num * minProd);

            result = Math.Max(result, maxProd);
        }

        return result;
    }

    // ------------------------------------------------------------
    // Test Section
    // ------------------------------------------------------------
    public static void Main()
    {
        int[] nums = { 2, 3, -2, 4 };
        int result = MaxProduct(nums);

        Console.WriteLine("Input: [" + string.Join(", ", nums) + "]");
        Console.WriteLine("Maximum Product Subarray: " + result);
    }
}
