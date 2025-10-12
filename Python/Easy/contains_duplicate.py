"""
Problem: Contains Duplicate
Link: https://leetcode.com/problems/contains-duplicate/

Task:
Given an integer array nums, return True if any value appears at least twice
in the array, and False if every element is distinct.
"""

# ------------------------------------------------------------
# 🔹 Solution 1: Brute Force
# ------------------------------------------------------------
# Idea:
#   Compare every pair of elements (i, j) where i != j.
#   If any pair matches, return True.
#
# Time Complexity: O(n^2)
# Space Complexity: O(1)
# ------------------------------------------------------------
def contains_duplicate_bruteforce(nums: list[int]) -> bool:
    for i in range(len(nums)):
        for j in range(i + 1, len(nums)):
            if nums[i] == nums[j]:
                return True
    return False


# ------------------------------------------------------------
# ⚡ Solution 2: HashSet
# ------------------------------------------------------------
# Idea:
#   Use a set to track seen numbers.
#   If a number is already in the set, it's a duplicate.
#
# Time Complexity: O(n)
# Space Complexity: O(n)
# ------------------------------------------------------------
def contains_duplicate_hashset(nums: list[int]) -> bool:
    seen = set()
    for num in nums:
        if num in seen:
            return True
        seen.add(num)
    return False


# ------------------------------------------------------------
# 🔸 Solution 3: Sorting
# ------------------------------------------------------------
# Idea:
#   Sort the array and check if any consecutive elements are equal.
#
# Time Complexity: O(n log n)
# Space Complexity: O(1) or O(n) depending on sort implementation
# ------------------------------------------------------------
def contains_duplicate_sorting(nums: list[int]) -> bool:
    nums.sort()
    for i in range(1, len(nums)):
        if nums[i] == nums[i - 1]:
            return True
    return False


# ------------------------------------------------------------
# 🧪 Test Section
# ------------------------------------------------------------
if __name__ == "__main__":
    test_cases = [
        [1, 2, 3, 1],
        [1, 2, 3, 4],
        [1, 1, 1, 3, 3, 4, 3, 2, 4, 2],
        [],
        [0],
    ]

    for nums in test_cases:
        print(f"{nums} -> "
              f"BruteForce: {contains_duplicate_bruteforce(nums)}, "
              f"HashSet: {contains_duplicate_hashset(nums)}, "
              f"Sorting: {contains_duplicate_sorting(nums)}")
