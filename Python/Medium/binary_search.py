"""
Problem: Binary Search
Link: https://leetcode.com/problems/binary-search/

Task:
Given a sorted array of integers `nums` and an integer `target`,
return the index of `target` if it exists in the array. Otherwise, return -1.

Example:
Input: nums = [-1, 0, 3, 5, 9, 12], target = 9
Output: 4
"""

# ------------------------------------------------------------
# Solution: Iterative Binary Search
# ------------------------------------------------------------
# Time Complexity: O(log n)
# Space Complexity: O(1)
# Explanation:
#   Repeatedly divide the search range in half until the target is found
#   or the range becomes empty.
# ------------------------------------------------------------

def binary_search(nums, target):
    left, right = 0, len(nums) - 1

    while left <= right:
        mid = (left + right) // 2  # find middle index

        if nums[mid] == target:
            return mid
        elif nums[mid] < target:
            left = mid + 1  # search right half
        else:
            right = mid - 1  # search left half

    return -1


# ------------------------------------------------------------
#  Test Section
# ------------------------------------------------------------
if __name__ == "__main__":
    nums = [-1, 0, 3, 5, 9, 12]
    target = 9
    print("Input:", nums)
    print("Target:", target)
    print("Output:", binary_search(nums, target))  # Expected: 4
