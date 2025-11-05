/*
Problem: Fibonacci Number
Link: https://leetcode.com/problems/fibonacci-number/

Task:
Given an integer `n`, return the `n`th Fibonacci number.

Example:
Input: n = 4
Output: 3  (because Fibonacci sequence is: 0, 1, 1, 2, 3...)
*/

// ------------------------------------------------------------
//  Solution 1: Recursive
// ------------------------------------------------------------
// Time Complexity: O(2^n)
// Space Complexity: O(n) due to call stack
// Explanation:
//   Recursively calculate Fibonacci using the relation:
//   F(n) = F(n-1) + F(n-2)
// ------------------------------------------------------------

public class Solution {
    public int FibRecursive(int n) {
        if (n <= 1)
            return n;

        return FibRecursive(n - 1) + FibRecursive(n - 2);
    }
}


// ------------------------------------------------------------
//  Solution 2: Iterative (Efficient)
// ------------------------------------------------------------
// Time Complexity: O(n)
// Space Complexity: O(1)
// Explanation:
//   Use two variables to iteratively compute Fibonacci numbers.
// ------------------------------------------------------------

public class Solution2 {
    public int Fib(int n) {
        if (n <= 1)
            return n;

        int prev = 0, curr = 1;
        
        for (int i = 2; i <= n; i++) {
            int next = prev + curr;
            prev = curr;
            curr = next;
        }

        return curr;
    }
}


// ------------------------------------------------------------
//  Test Section
// ------------------------------------------------------------
public class Program {
    public static void Main(string[] args) {
        int n = 10;

        Solution recursive = new Solution();
        Solution2 iterative = new Solution2();

        Console.WriteLine("Recursive Solution: " + recursive.FibRecursive(n));
        Console.WriteLine("Iterative Solution: " + iterative.Fib(n));
    }
}
