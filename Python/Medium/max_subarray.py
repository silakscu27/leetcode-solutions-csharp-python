"""
Problem: Maximum Subarray
Link: https://leetcode.com/problems/maximum-subarray/

Task:
Given an integer array `nums`, find the contiguous subarray
(containing at least one number) which has the largest sum
and return its sum.

Example:
Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
Output: 6   # because [4,-1,2,1] has the largest sum = 6
"""

def max_subarray(nums):
    # if the array is empty, no sum can be calculated
    if not nums:
        return 0

    # initialize both current_sum and max_sum with the first element
    current_sum = max_sum = nums[0]

    # iterate through the rest of the array
    for num in nums[1:]:
        # decide whether to start a new subarray or continue the current one
        current_sum = max(num, current_sum + num)

        # update max_sum if current_sum is greater
        max_sum = max(max_sum, current_sum)

    return max_sum


# ------------------------------------------------------------
# Test Section
# ------------------------------------------------------------
if __name__ == "__main__":
    nums = [-2, 1, -3, 4, -1, 2, 1, -5, 4]
    print("Maximum Subarray Sum:", max_subarray(nums))
