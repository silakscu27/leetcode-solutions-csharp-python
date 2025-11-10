// Problem: Product of Array Except Self
// Link: https://leetcode.com/problems/product-of-array-except-self/
//
// Task:
// Given an integer array nums, return an array answer such that 
// answer[i] is equal to the product of all the elements of nums except nums[i].
//
// Constraints:
// - You must solve it without using division.
// - Your solution must run in O(n) time.
//
// Example:
// Input: nums = [1, 2, 3, 4]
// Output: [24, 12, 8, 6]

using System;

public class ProductExceptSelfSolution
{
    // ------------------------------------------------------------
    // Approach: Prefix and Suffix Products
    // ------------------------------------------------------------
    // 1. First pass: compute prefix product for each element.
    // 2. Second pass: traverse from the end to multiply by the suffix product.
    // Time Complexity: O(n)
    // Space Complexity: O(1) (excluding output array)
    // ------------------------------------------------------------
    public static int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;
        int[] result = new int[n];

        // Initialize result with prefix products
        int prefix = 1;
        for (int i = 0; i < n; i++)
        {
            result[i] = prefix;
            prefix *= nums[i];
        }

        // Multiply by suffix products
        int suffix = 1;
        for (int i = n - 1; i >= 0; i--)
        {
            result[i] *= suffix;
            suffix *= nums[i];
        }

        return result;
    }

    // ------------------------------------------------------------
    // Test Section
    // ------------------------------------------------------------
    public static void Main()
    {
        int[] nums = { 1, 2, 3, 4 };
        int[] result = ProductExceptSelf(nums);

        Console.WriteLine("Input: [" + string.Join(", ", nums) + "]");
        Console.WriteLine("Output: [" + string.Join(", ", result) + "]");
    }
}
