"""
Problem: Merge Sorted Array
Link: https://leetcode.com/problems/merge-sorted-array/

You’re given two sorted integer arrays, nums1 and nums2, along with their counts m and n.
Merge nums2 into nums1 so that nums1 becomes a single sorted array in-place.

Example:
    nums1 = [1,2,3,0,0,0], m = 3
    nums2 = [2,5,6], n = 3
Result:
    [1,2,2,3,5,6]
"""

# ------------------------------------------------------------
# In-place merge (optimal)
# ------------------------------------------------------------
# Works from the end to avoid overwriting elements in nums1.
# Time: O(m + n)
# Space: O(1)
# ------------------------------------------------------------

def merge(nums1, m, nums2, n):
    i = m - 1
    j = n - 1
    k = m + n - 1

    while i >= 0 and j >= 0:
        if nums1[i] > nums2[j]:
            nums1[k] = nums1[i]
            i -= 1
        else:
            nums1[k] = nums2[j]
            j -= 1
        k -= 1

    # If nums2 still has elements left, copy them
    while j >= 0:
        nums1[k] = nums2[j]
        j -= 1
        k -= 1


# ------------------------------------------------------------
# Simple merge using extra space (easier to read)
# ------------------------------------------------------------
# Time: O((m + n) log (m + n))
# Space: O(m + n)
# ------------------------------------------------------------

def merge_simple(nums1, m, nums2, n):
    merged = sorted(nums1[:m] + nums2)
    for i in range(m + n):
        nums1[i] = merged[i]


# ------------------------------------------------------------
# Quick test
# ------------------------------------------------------------
if __name__ == "__main__":
    nums1 = [1, 2, 3, 0, 0, 0]
    nums2 = [2, 5, 6]
    merge(nums1, 3, nums2, 3)
    print("In-place merge:", nums1)

    nums1 = [1, 2, 3, 0, 0, 0]
    merge_simple(nums1, 3, nums2, 3)
    print("Simple merge:", nums1)
