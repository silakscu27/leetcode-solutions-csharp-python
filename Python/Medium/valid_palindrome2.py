"""
Problem: Valid Palindrome II
Link: https://leetcode.com/problems/valid-palindrome-ii/

Task:
Given a string `s`, return true if the string can be a palindrome 
after deleting at most one character.

Example:
Input: s = "abca"
Output: true
Explanation: Deleting 'b' or 'c' results in "aca" or "aba", both are palindromes.
"""

# ------------------------------------------------------------
#  Helper Function: Check Palindrome
# ------------------------------------------------------------
#   Checks if a given substring (by indices) is palindrome.
# ------------------------------------------------------------

def is_palindrome_range(s, left, right):
    while left < right:
        if s[left] != s[right]:
            return False
        left += 1
        right -= 1
    return True


# ------------------------------------------------------------
#  Solution: Two Pointers + One Deletion Allowed
# ------------------------------------------------------------
# Time Complexity: O(n)
# Space Complexity: O(1)
# Explanation:
#   Use two pointers from both ends.
#   If mismatch found, try skipping one character (left or right).
#   If either substring is palindrome → return True.
# ------------------------------------------------------------

def valid_palindrome(s):
    left, right = 0, len(s) - 1

    while left < right:
        if s[left] != s[right]:
            # Try removing one character either from left or right
            return is_palindrome_range(s, left + 1, right) or is_palindrome_range(s, left, right - 1)
        left += 1
        right -= 1

    return True


# ------------------------------------------------------------
#   Test Section
# ------------------------------------------------------------
if __name__ == "__main__":
    test_cases = [
        ("aba", True),
        ("abca", True),
        ("abc", False),
        ("deeee", True),
        ("cbbcc", True)
    ]

    for s, expected in test_cases:
        print(f"Input: '{s}' → Output: {valid_palindrome(s)} | Expected: {expected}")
