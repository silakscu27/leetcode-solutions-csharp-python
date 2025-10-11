"""
Problem: Two Sum
Link: https://leetcode.com/problems/two-sum/

Task:
Given an array of integers `nums` and an integer `target`,
return the indices of the two numbers such that they add up to `target`.

Example:
Input: nums = [2,7,11,15], target = 9
Output: [0,1]
"""

# ------------------------------------------------------------
# 🧩 Solution 1:
# ------------------------------------------------------------
# Time Complexity: O(n^2)
# Space Complexity: O(1)
# Explanation:
#   Compare every pair of numbers and check if they sum to target.
# ------------------------------------------------------------

def two_sum(nums, target):
    for i in range(len(nums)):
        for j in range(i + 1, len(nums)):
            if nums[i] + nums[j] == target:
                return [i, j]
    return []


# ------------------------------------------------------------
# ⚡ Solution 2: 
# ------------------------------------------------------------
# Time Complexity: O(n)
# Space Complexity: O(n)
# Explanation:
#   Use a hash map (dictionary) to store seen numbers and their indices.
#   For each number, check if its complement (target - num) exists in the map.
# ------------------------------------------------------------

def two_sum2(nums, target):
    seen = {}  # {number: index}

    for i, num in enumerate(nums):
        complement = target - num
        if complement in seen:
            return [seen[complement], i]
        seen[num] = i

    return []


# ------------------------------------------------------------
# 🧪 Test Section
# ------------------------------------------------------------
if __name__ == "__main__":
    nums = [2, 7, 11, 15]
    target = 9

    print("Solution 1:", two_sum(nums, target))
    print("Solution 2:", two_sum2(nums, target))
