"""
Problem: Maximum Depth of Binary Tree
Link: https://leetcode.com/problems/maximum-depth-of-binary-tree/

Task:
Given the `root` of a binary tree, return its maximum depth.
Maximum depth = number of nodes along the longest path from root to leaf.

Example:
Input: [3,9,20,null,null,15,7]
Output: 3
Explanation:
       3
      / \
     9  20
       /  \
      15   7
"""

# ------------------------------------------------------------
#  Definition for a binary tree node
# ------------------------------------------------------------
class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right


# ------------------------------------------------------------
#  Solution 1: Recursive DFS
# ------------------------------------------------------------
# Time Complexity: O(n)
# Space Complexity: O(h) where h = height of tree (worst O(n))
# Explanation:
#   For each node: depth = 1 + max(depth of left, depth of right)
# ------------------------------------------------------------

def max_depth_recursive(root):
    if not root:
        return 0
    return 1 + max(max_depth_recursive(root.left), max_depth_recursive(root.right))


# ------------------------------------------------------------
#  Solution 2: BFS (Queue)
# ------------------------------------------------------------
# Time Complexity: O(n)
# Space Complexity: O(n)
# Explanation:
#   Level-order traversal: depth = number of levels
# ------------------------------------------------------------

from collections import deque

def max_depth_bfs(root):
    if not root:
        return 0

    queue = deque([root])
    depth = 0

    while queue:
        level_size = len(queue)
        for _ in range(level_size):
            node = queue.popleft()
            if node.left: queue.append(node.left)
            if node.right: queue.append(node.right)
        depth += 1

    return depth


# ------------------------------------------------------------
#  Test Section
# ------------------------------------------------------------
if __name__ == "__main__":
    # Example Tree:
    #       3
    #      / \
    #     9  20
    #       /  \
    #      15   7

    root = TreeNode(3)
    root.left = TreeNode(9)
    root.right = TreeNode(20, TreeNode(15), TreeNode(7))

    print("Recursive DFS Depth:", max_depth_recursive(root))
    print("BFS Depth:", max_depth_bfs(root))
