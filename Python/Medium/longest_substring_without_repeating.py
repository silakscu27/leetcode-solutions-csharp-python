"""
Problem: Longest Substring Without Repeating Characters
Link: https://leetcode.com/problems/longest-substring-without-repeating-characters/

Task:
Given a string s, find the length of the longest substring without repeating characters.

Example:
Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with a length of 3.
"""

def length_of_longest_substring(s: str) -> int:
    # Sliding window approach using two pointers
    seen = set()
    left = 0
    max_len = 0

    for right in range(len(s)):
        # If we find a duplicate, move the left pointer until it's gone
        while s[right] in seen:
            seen.remove(s[left])
            left += 1

        seen.add(s[right])
        max_len = max(max_len, right - left + 1)

    return max_len


# Test section
if __name__ == "__main__":
    test_cases = [
        ("abcabcbb", 3),
        ("bbbbb", 1),
        ("pwwkew", 3),
        ("", 0),
        ("au", 2),
    ]

    for s, expected in test_cases:
        result = length_of_longest_substring(s)
        print(f"Input: '{s}' → Output: {result} (Expected: {expected})")
