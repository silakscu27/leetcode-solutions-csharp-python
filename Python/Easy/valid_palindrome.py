"""
Problem: Valid Palindrome
Link: https://leetcode.com/problems/valid-palindrome/

Task:
Given a string s, determine if it is a palindrome,
considering only alphanumeric characters and ignoring cases.
"""

import re

# ------------------------------------------------------------
# ⚡ Solution: Two-Pointer Technique
# ------------------------------------------------------------
# Time Complexity: O(n)
# Space Complexity: O(1)
# ------------------------------------------------------------
def is_palindrome(s: str) -> bool:
    # Filter alphanumeric and lowercase
    filtered = re.sub(r'[^a-zA-Z0-9]', '', s).lower()

    left, right = 0, len(filtered) - 1
    while left < right:
        if filtered[left] != filtered[right]:
            return False
        left += 1
        right -= 1
    return True


# ------------------------------------------------------------
# 🧪 Test Section
# ------------------------------------------------------------
if __name__ == "__main__":
    test_cases = [
        "A man, a plan, a canal: Panama",
        "race a car",
        " ",
        "No lemon, no melon"
    ]

    for case in test_cases:
        print(f"{case!r} -> {is_palindrome(case)}")
