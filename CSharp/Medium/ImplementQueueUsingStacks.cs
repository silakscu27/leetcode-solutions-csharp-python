// Problem: Implement Queue using Stacks
// Link: https://leetcode.com/problems/implement-queue-using-stacks/
//
// Task:
// Implement a first-in-first-out (FIFO) queue using only two stacks.
// The implemented queue should support standard operations:
// push(x), pop(), peek(), and empty().
//
// Example:
// Input:
// ["MyQueue", "push", "push", "peek", "pop", "empty"]
// [[], [1], [2], [], [], []]
// Output:
// [null, null, null, 1, 1, false]
//
// Explanation:
// MyQueue myQueue = new MyQueue();
// myQueue.Push(1); // queue: [1]
// myQueue.Push(2); // queue: [1, 2]
// myQueue.Peek();  // return 1
// myQueue.Pop();   // return 1
// myQueue.Empty(); // return false

using System;
using System.Collections.Generic;

public class MyQueue
{
    private Stack<int> inputStack;
    private Stack<int> outputStack;

    // ------------------------------------------------------------
    // Constructor
    // ------------------------------------------------------------
    public MyQueue()
    {
        inputStack = new Stack<int>();
        outputStack = new Stack<int>();
    }

    // ------------------------------------------------------------
    // Push(x): Add element to the end of the queue
    // ------------------------------------------------------------
    public void Push(int x)
    {
        inputStack.Push(x);
    }

    // ------------------------------------------------------------
    // Pop(): Remove element from the front of the queue
    // ------------------------------------------------------------
    public int Pop()
    {
        if (outputStack.Count == 0)
        {
            // Move all elements from inputStack to outputStack
            while (inputStack.Count > 0)
            {
                outputStack.Push(inputStack.Pop());
            }
        }

        return outputStack.Pop();
    }

    // ------------------------------------------------------------
    // Peek(): Get the front element without removing it
    // ------------------------------------------------------------
    public int Peek()
    {
        if (outputStack.Count == 0)
        {
            while (inputStack.Count > 0)
            {
                outputStack.Push(inputStack.Pop());
            }
        }

        return outputStack.Peek();
    }

    // ------------------------------------------------------------
    // Empty(): Check if the queue is empty
    // ------------------------------------------------------------
    public bool Empty()
    {
        return inputStack.Count == 0 && outputStack.Count == 0;
    }
}


// ------------------------------------------------------------
// Test Section
// ------------------------------------------------------------
public class Program
{
    public static void Main()
    {
        MyQueue myQueue = new MyQueue();

        myQueue.Push(1);
        myQueue.Push(2);

        Console.WriteLine("Peek: " + myQueue.Peek()); // 1
        Console.WriteLine("Pop: " + myQueue.Pop());   // 1
        Console.WriteLine("Empty: " + myQueue.Empty()); // False
    }
}
