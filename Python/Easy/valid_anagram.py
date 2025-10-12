"""
Problem: Valid Anagram
Link: https://leetcode.com/problems/valid-anagram/

Task:
Given two strings s and t, return True if t is an anagram of s, and False otherwise.
"""

# ------------------------------------------------------------
# 🔹 Solution 1: Sorting
# ------------------------------------------------------------
# Idea:
#   If two strings are anagrams, their sorted versions will be identical.
#
# Time Complexity: O(n log n)
# Space Complexity: O(1) or O(n) depending on sort implementation
# ------------------------------------------------------------
def is_anagram_sorting(s: str, t: str) -> bool:
    if len(s) != len(t):
        return False
    return sorted(s) == sorted(t)


# ------------------------------------------------------------
# ⚡ Solution 2: HashMap (Character Counting)
# ------------------------------------------------------------
# Idea:
#   Count each character’s frequency in both strings.
#   If all counts match, they are anagrams.
#
# Time Complexity: O(n)
# Space Complexity: O(1) or O(k), where k = number of unique characters
# ------------------------------------------------------------
def is_anagram_hashmap(s: str, t: str) -> bool:
    if len(s) != len(t):
        return False

    count = {}

    # Count characters in s
    for ch in s:
        count[ch] = count.get(ch, 0) + 1

    # Subtract counts for t
    for ch in t:
        if ch not in count:
            return False
        count[ch] -= 1
        if count[ch] < 0:
            return False

    return True


# ------------------------------------------------------------
# 🧪 Test Section
# ------------------------------------------------------------
if __name__ == "__main__":
    test_cases = [
        ("anagram", "nagaram"),
        ("rat", "car"),
        ("listen", "silent"),
        ("aacc", "ccac")
    ]

    for s, t in test_cases:
        print(f"{s!r}, {t!r} -> Sorting: {is_anagram_sorting(s, t)}, HashMap: {is_anagram_hashmap(s, t)}")
