"""
Problem: Merge Sorted Array
Link: https://leetcode.com/problems/merge-sorted-array/

Task:
Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1
as one sorted array. Assume nums1 has enough space (size that is equal to m + n)
to hold additional elements from nums2.

Example:
Input: nums1 = [1,2,3,0,0,0], m = 3
       nums2 = [2,5,6],       n = 3
Output: [1,2,2,3,5,6]
"""

def merge(nums1, m, nums2, n):
    # Last index of merged array
    p = m + n - 1
    # Last index for nums1 and nums2 elements
    p1, p2 = m - 1, n - 1

    # Traverse from the end and fill nums1
    while p1 >= 0 and p2 >= 0:
        if nums1[p1] > nums2[p2]:
            nums1[p] = nums1[p1]
            p1 -= 1
        else:
            nums1[p] = nums2[p2]
            p2 -= 1
        p -= 1

    # If any elements left in nums2, copy them
    while p2 >= 0:
        nums1[p] = nums2[p2]
        p2 -= 1
        p -= 1

# ------------------------------------------------------------
# Test Section
# ------------------------------------------------------------
if __name__ == "__main__":
    nums1 = [1,2,3,0,0,0]
    m = 3
    nums2 = [2,5,6]
    n = 3

    merge(nums1, m, nums2, n)
    print("Merged Array:", nums1)
