"""
Problem: Valid Parentheses
Link: https://leetcode.com/problems/valid-parentheses/

Check if the input string has valid parentheses pairing.
"""

def is_valid(s: str) -> bool:
    stack = []
    pairs = {')': '(', '}': '{', ']': '['}

    for char in s:
        # If it's a closing bracket
        if char in pairs:
            if not stack or stack[-1] != pairs[char]:
                return False
            stack.pop()
        else:
            # Opening bracket
            stack.append(char)

    return not stack  # True if empty


# ------------------------------------------------------------
# Quick test
# ------------------------------------------------------------
if __name__ == "__main__":
    tests = ["()", "()[]{}", "(]", "([)]", "{[]}"]
    for t in tests:
        print(f"{t:8} -> {is_valid(t)}")
