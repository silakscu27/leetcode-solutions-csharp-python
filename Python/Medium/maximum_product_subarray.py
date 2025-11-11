"""
Problem: Maximum Product Subarray
Link: https://leetcode.com/problems/maximum-product-subarray/

Task:
Given an integer array nums, find the contiguous subarray within an array
(containing at least one number) which has the largest product.

Example:
Input: nums = [2,3,-2,4]
Output: 6
Explanation: [2,3] has the largest product 6.
"""

# ------------------------------------------------------------
# Approach: Dynamic Programming with max and min tracking
# ------------------------------------------------------------
# 1. Track both maximum and minimum product ending at each index.
# 2. Negative numbers can turn a minimum product into a maximum.
# 3. Update global maximum at each step.
# ------------------------------------------------------------

def max_product(nums):
    if not nums:
        return 0

    # Initialize max and min products with first element
    max_prod = min_prod = result = nums[0]

    for num in nums[1:]:
        if num < 0:
            # Swap max and min if number is negative
            max_prod, min_prod = min_prod, max_prod

        # Update max and min products
        max_prod = max(num, num * max_prod)
        min_prod = min(num, num * min_prod)

        # Update result
        result = max(result, max_prod)

    return result

# ------------------------------------------------------------
# Test Section
# ------------------------------------------------------------
if __name__ == "__main__":
    nums = [2, 3, -2, 4]
    print("Input:", nums)
    print("Maximum Product Subarray:", max_product(nums))
