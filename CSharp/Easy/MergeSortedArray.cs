using System;

namespace Algorithms
{
    public static class MergeSortedArray
    {
        /*
         * Problem: Merge Sorted Array
         * Link: https://leetcode.com/problems/merge-sorted-array/
         *
         * You are given two sorted integer arrays nums1 and nums2, along with
         * their counts m and n. Merge nums2 into nums1 so that it becomes one
         * sorted array in-place.
         *
         * Example:
         *   nums1 = [1,2,3,0,0,0], m = 3
         *   nums2 = [2,5,6], n = 3
         *   Output: [1,2,2,3,5,6]
         */

        // ------------------------------------------------------------
        // In-place merge (optimal)
        // ------------------------------------------------------------
        // Time Complexity: O(m + n)
        // Space Complexity: O(1)
        // ------------------------------------------------------------
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;

            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    j--;
                }
                k--;
            }

            while (j >= 0)
            {
                nums1[k] = nums2[j];
                j--;
                k--;
            }
        }

        // ------------------------------------------------------------
        // Simple merge using extra space
        // ------------------------------------------------------------
        // Easier to read, but uses additional memory.
        // Time Complexity: O((m + n) log(m + n))
        // Space Complexity: O(m + n)
        // ------------------------------------------------------------
        public static void MergeWithExtraSpace(int[] nums1, int m, int[] nums2, int n)
        {
            int[] merged = new int[m + n];
            Array.Copy(nums1, 0, merged, 0, m);
            Array.Copy(nums2, 0, merged, m, n);

            Array.Sort(merged);

            for (int i = 0; i < merged.Length; i++)
            {
                nums1[i] = merged[i];
            }
        }

        // ------------------------------------------------------------
        // Quick test
        // ------------------------------------------------------------
        public static void Test()
        {
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = { 2, 5, 6 };

            Merge(nums1, 3, nums2, 3);
            Console.WriteLine("In-place merge: " + string.Join(", ", nums1));

            int[] nums1b = { 1, 2, 3, 0, 0, 0 };
            MergeWithExtraSpace(nums1b, 3, nums2, 3);
            Console.WriteLine("Simple merge: " + string.Join(", ", nums1b));
        }
    }
}
