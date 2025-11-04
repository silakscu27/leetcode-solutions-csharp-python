"""
Problem: Palindrome Number
Link: https://leetcode.com/problems/palindrome-number/

Task:
Given an integer `x`, return True if `x` is a palindrome, otherwise return False.
A palindrome number reads the same backward as forward.

Example:
Input: x = 121
Output: True

Example:
Input: x = -121
Output: False
Explanation: From right to left it becomes 121-, which is not the same.
"""
# ------------------------------------------------------------
#  Solution 1: Convert to string
# ------------------------------------------------------------
# Time Complexity: O(n)
# Space Complexity: O(n)
# Explanation:
#   Convert number to string and check if it reads the same reversed.
# ------------------------------------------------------------

def is_palindrome_str(x):
    s = str(x)
    return s == s[::-1]


# ------------------------------------------------------------
#  Test Section
# ------------------------------------------------------------
if __name__ == "__main__":
    tests = [121, -121, 10, 12321, 0]

    for num in tests:
        print(f"{num} -> str method: {is_palindrome_str(num)}")
