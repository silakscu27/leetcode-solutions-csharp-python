// Problem: Merge Sorted Array
// Link: https://leetcode.com/problems/merge-sorted-array/
//
// Task:
// Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1
// as one sorted array. Assume nums1 has enough space (size that is equal to m + n)
// to hold additional elements from nums2.
//
// Example:
// Input: nums1 = [1,2,3,0,0,0], m = 3
//        nums2 = [2,5,6],       n = 3
// Output: [1,2,2,3,5,6]

using System;

public class MergeSortedArraySolutions
{
    // ------------------------------------------------------------
    //  Solution: Two-pointer from the end
    // ------------------------------------------------------------
    // Time Complexity: O(m+n)
    // Space Complexity: O(1)
    // Explanation:
    //   - Start filling nums1 from the last index
    //   - Compare elements from the end of nums1 and nums2
    //   - Place the bigger element in the current position
    //   - After main loop, copy any remaining nums2 elements
    // ------------------------------------------------------------
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int p1 = m - 1;          // Pointer for nums1
        int p2 = n - 1;          // Pointer for nums2
        int p = m + n - 1;       // Pointer for placement in nums1

        while (p1 >= 0 && p2 >= 0)
        {
            if (nums1[p1] > nums2[p2])
            {
                nums1[p] = nums1[p1];
                p1--;
            }
            else
            {
                nums1[p] = nums2[p2];
                p2--;
            }
            p--;
        }

        // Copy any remaining elements from nums2
        while (p2 >= 0)
        {
            nums1[p] = nums2[p2];
            p2--;
            p--;
        }
    }

    // ------------------------------------------------------------
    //  Test Section
    // ------------------------------------------------------------
    public static void Main()
    {
        int[] nums1 = { 1, 2, 3, 0, 0, 0 };
        int m = 3;
        int[] nums2 = { 2, 5, 6 };
        int n = 3;

        Merge(nums1, m, nums2, n);
        Console.WriteLine("Merged Array: [" + string.Join(", ", nums1) + "]");
    }
}
