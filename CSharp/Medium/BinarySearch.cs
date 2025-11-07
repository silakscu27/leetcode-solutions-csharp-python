// Problem: Binary Search
// Link: https://leetcode.com/problems/binary-search/
//
// Task:
// Given a sorted array of integers `nums` and an integer `target`,
// return the index of `target` if it exists in the array. Otherwise, return -1.
//
// Example:
// Input: nums = [-1,0,3,5,9,12], target = 9
// Output: 4

using System;

public class BinarySearchSolution
{
    // ------------------------------------------------------------
    // Solution: Iterative Binary Search
    // ------------------------------------------------------------
    // Time Complexity: O(log n)
    // Space Complexity: O(1)
    // Explanation:
    //   Use two pointers (left and right) to repeatedly divide the search space.
    //   Compare the middle element with the target and narrow down the range
    //   accordingly until the target is found or range becomes empty.
    // ------------------------------------------------------------
    public static int BinarySearch(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2; 

            if (nums[mid] == target)
                return mid;
            else if (nums[mid] < target)
                left = mid + 1; 
            else
                right = mid - 1; 
        }

        return -1; 
    }

    // ------------------------------------------------------------
    // Test Section
    // ------------------------------------------------------------
    public static void Main()
    {
        int[] nums = { -1, 0, 3, 5, 9, 12 };
        int target = 9;

        int result = BinarySearch(nums, target);
        Console.WriteLine("Input: [" + string.Join(", ", nums) + "]");
        Console.WriteLine("Target: " + target);
        Console.WriteLine("Output: " + result); // Expected: 4
    }
}
