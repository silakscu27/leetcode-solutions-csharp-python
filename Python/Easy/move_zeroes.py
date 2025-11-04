"""
Problem: Move Zeroes
Link: https://leetcode.com/problems/move-zeroes/

Task:
Given an integer array `nums`, move all zeros to the end of the array
while maintaining the relative order of non-zero elements.
Do this in-place without making a copy of the array.

Example:
Input:  nums = [0,1,0,3,12]
Output: [1,3,12,0,0]
"""
# ------------------------------------------------------------
# Solution 1: Brute Force 
# ------------------------------------------------------------
# Time Complexity: O(n^2)
# Space Complexity: O(1)
# Explanation:
#   When a zero is found, search ahead for the next non-zero value
#   and swap positions.
# ------------------------------------------------------------

def move_zeroes_bruteforce(nums):
    for i in range(len(nums)):
        if nums[i] == 0:
            for j in range(i + 1, len(nums)):
                if nums[j] != 0:
                    nums[i], nums[j] = nums[j], nums[i]
                    break


# ------------------------------------------------------------
#  Solution 2: Two-Pointer 
# ------------------------------------------------------------
# Time Complexity: O(n)
# Space Complexity: O(1)
# Explanation:
#   First pass: push all non-zero values forward in order.
#   Second pass: fill the rest with zeros.
# ------------------------------------------------------------

def move_zeroes(nums):
    insert_pos = 0  # Position to place the next non-zero number

    # Move non-zero elements to the front
    for num in nums:
        if num != 0:
            nums[insert_pos] = num
            insert_pos += 1

    # Fill the remaining positions with zeroes
    for i in range(insert_pos, len(nums)):
        nums[i] = 0


# ------------------------------------------------------------
# Test Section
# ------------------------------------------------------------
if __name__ == "__main__":
    nums1 = [0, 1, 0, 3, 12]
    nums2 = [0, 1, 0, 3, 12]

    move_zeroes_bruteforce(nums1)
    move_zeroes(nums2)

    print("Brute Force:", nums1)   # Output: [1, 3, 12, 0, 0]
    print("Optimal:", nums2)       # Output: [1, 3, 12, 0, 0]
