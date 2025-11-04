// Problem: Move Zeroes
// Link: https://leetcode.com/problems/move-zeroes/
//
// Task:
// Given an integer array `nums`, move all zeros to the end of the array
// while maintaining the relative order of non-zero elements.
// Modify the array in-place.
//
// Example:
// Input: nums = [0,1,0,3,12]
// Output: [1,3,12,0,0]

using System;

public class MoveZeroesSolutions
{
    // ------------------------------------------------------------
    // Solution 1: Brute Force 
    // ------------------------------------------------------------
    // Time Complexity: O(n^2)
    // Space Complexity: O(1)
    // Explanation:
    //   When a zero is found, scan forward to find a non-zero
    //   and swap positions.
    // ------------------------------------------------------------
    public static void MoveZeroesBruteForce(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] != 0)
                    {
                        (nums[i], nums[j]) = (nums[j], nums[i]); // swap
                        break;
                    }
                }
            }
        }
    }

    // ------------------------------------------------------------
    // Solution 2: Two-Pointer 
    // ------------------------------------------------------------
    // Time Complexity: O(n)
    // Space Complexity: O(1)
    // Explanation:
    //   - Move all non-zero values to the front
    //   - Fill the remaining positions with zeros
    // ------------------------------------------------------------
    public static void MoveZeroes(int[] nums)
    {
        int insertPos = 0; // index to place next non-zero

        // Move all non-zero elements forward
        foreach (int num in nums)
        {
            if (num != 0)
            {
                nums[insertPos] = num;
                insertPos++;
            }
        }

        // Fill the rest with zeros
        for (int i = insertPos; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }

    // ------------------------------------------------------------
    // Test Section
    // ------------------------------------------------------------
    public static void Main()
    {
        int[] nums1 = { 0, 1, 0, 3, 12 };
        int[] nums2 = { 0, 1, 0, 3, 12 };

        MoveZeroesBruteForce(nums1);
        MoveZeroes(nums2);

        Console.WriteLine("Brute Force: [" + string.Join(", ", nums1) + "]");
        Console.WriteLine("Optimal:     [" + string.Join(", ", nums2) + "]");
    }
}
