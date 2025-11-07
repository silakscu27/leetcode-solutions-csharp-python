# Problem: Implement Queue using Stacks
# Link: https://leetcode.com/problems/implement-queue-using-stacks/
#
# Task:
# Implement a first in first out (FIFO) queue using only two stacks.
# The implemented queue should support all the standard queue operations:
# push(x), pop(), peek(), and empty().
#
# Example:
# Input:
# ["MyQueue", "push", "push", "peek", "pop", "empty"]
# [[], [1], [2], [], [], []]
# Output:
# [null, null, null, 1, 1, false]
#
# Explanation:
# MyQueue myQueue = new MyQueue();
# myQueue.push(1); // queue: [1]
# myQueue.push(2); // queue: [1, 2]
# myQueue.peek();  // return 1
# myQueue.pop();   // return 1
# myQueue.empty(); // return false


class MyQueue:
    def __init__(self):
        # input_stack: new elements pushed here
        # output_stack: elements popped/peeked from here
        self.input_stack = []
        self.output_stack = []

    # --------------------------------------------------------
    # push(x): add element to end of queue
    # --------------------------------------------------------
    def push(self, x: int) -> None:
        self.input_stack.append(x)

    # --------------------------------------------------------
    # pop(): remove element from front of queue
    # --------------------------------------------------------
    def pop(self) -> int:
        # if output stack is empty, move all from input to output
        if not self.output_stack:
            while self.input_stack:
                self.output_stack.append(self.input_stack.pop())
        # pop from output (which represents the queue front)
        return self.output_stack.pop()

    # --------------------------------------------------------
    # peek(): get the front element without removing
    # --------------------------------------------------------
    def peek(self) -> int:
        if not self.output_stack:
            while self.input_stack:
                self.output_stack.append(self.input_stack.pop())
        return self.output_stack[-1]  # top of output stack = front of queue

    # --------------------------------------------------------
    # empty(): check if queue is empty
    # --------------------------------------------------------
    def empty(self) -> bool:
        return not self.input_stack and not self.output_stack


# ------------------------------------------------------------
# Test Section
# ------------------------------------------------------------
if __name__ == "__main__":
    q = MyQueue()
    q.push(1)
    q.push(2)
    print(q.peek())  # 1
    print(q.pop())   # 1
    print(q.empty()) # False
