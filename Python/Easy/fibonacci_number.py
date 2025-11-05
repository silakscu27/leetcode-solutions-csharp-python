"""
Problem: Fibonacci Number
Link: https://leetcode.com/problems/fibonacci-number/

Task:
Given an integer `n`, return the `n`th Fibonacci number.

Example:
Input: n = 4
Output: 3  (because Fibonacci sequence is: 0, 1, 1, 2, 3...)
"""

# ------------------------------------------------------------
#  Solution 1: Recursive
# ------------------------------------------------------------
# Time Complexity: O(2^n)
# Space Complexity: O(n) (due to recursion stack)
# Explanation:
#   Recursively calculate Fibonacci by definition:
#   F(n) = F(n-1) + F(n-2)
# ------------------------------------------------------------

def fib_recursive(n):
    if n <= 1:
        return n
    return fib_recursive(n - 1) + fib_recursive(n - 2)


# ------------------------------------------------------------
#  Solution 2: Iterative 
# ------------------------------------------------------------
# Time Complexity: O(n)
# Space Complexity: O(1)
# Explanation:
#   Use two variables to iteratively build Fibonacci numbers.
# ------------------------------------------------------------

def fib_iterative(n):
    if n <= 1:
        return n

    prev, curr = 0, 1  # F(0) = 0, F(1) = 1
    for _ in range(2, n + 1):
        prev, curr = curr, prev + curr

    return curr


# ------------------------------------------------------------
#  Test Section
# ------------------------------------------------------------
if __name__ == "__main__":
    n = 10

    print("Recursive Solution:", fib_recursive(n))
    print("Iterative Solution:", fib_iterative(n))
