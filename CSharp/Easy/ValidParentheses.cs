using System;
using System.Collections.Generic;

public class Solution
{
    public static bool IsValid(string s)
    {
        // Stack to keep track of opening brackets
        Stack<char> stack = new();

        // Mapping of closing brackets to their corresponding opening ones
        Dictionary<char, char> pairs = new()
        {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };

        // Iterate through each character in the string
        foreach (char c in s)
        {
            // If it's a closing bracket
            if (pairs.ContainsKey(c))
            {
                // Check if stack is empty or the top element doesn't match
                if (stack.Count == 0 || stack.Peek() != pairs[c])
                    return false;

                // Valid pair found -> pop from stack
                stack.Pop();
            }
            else
            {
                // It's an opening bracket -> push onto stack
                stack.Push(c);
            }
        }

        // If the stack is empty, all brackets are properly closed
        return stack.Count == 0;
    }

    // ------------------------------------------------------------
    // Quick test
    // ------------------------------------------------------------
    public static void Main()
    {
        string[] tests = { "()", "()[]{}", "(]", "([)]", "{[]}" };

        foreach (var t in tests)
        {
            Console.WriteLine($"{t,-8} -> {IsValid(t)}");
        }
    }
}
