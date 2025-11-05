/*
Problem: Maximum Depth of Binary Tree
Link: https://leetcode.com/problems/maximum-depth-of-binary-tree/

Task:
Given the `root` of a binary tree, return its maximum depth.
Maximum depth = number of nodes along the longest path from root to leaf.

Example:
Input: [3,9,20,null,null,15,7]
Output: 3

Tree:
       3
      / \
     9  20
       /  \
      15   7
*/

// ------------------------------------------------------------
//  Definition for a binary tree node
// ------------------------------------------------------------
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}


// ------------------------------------------------------------
//  Solution 1: Recursive DFS
// ------------------------------------------------------------
// Time Complexity: O(n)
// Space Complexity: O(h) where h = tree height
// Explanation:
//   Depth = 1 + max(depth(left), depth(right))
// ------------------------------------------------------------
public class SolutionRecursive {
    public int MaxDepth(TreeNode root) {
        if (root == null)
            return 0;

        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
}


// ------------------------------------------------------------
//  Solution 2: BFS (Level-order Traversal)
// ------------------------------------------------------------
// Time Complexity: O(n)
// Space Complexity: O(n) due to queue
// Explanation:
//   Count tree levels using queue
// ------------------------------------------------------------

public class SolutionBFS {
    public int MaxDepth(TreeNode root) {
        if (root == null)
            return 0;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int depth = 0;

        while (queue.Count > 0) {
            int levelSize = queue.Count;

            for (int i = 0; i < levelSize; i++) {
                TreeNode node = queue.Dequeue();
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }

            depth++;
        }

        return depth;
    }
}


// ------------------------------------------------------------
//  Test Section
// ------------------------------------------------------------
public class Program {
    public static void Main(string[] args) {
        TreeNode root = new TreeNode(3);
        root.left = new TreeNode(9);
        root.right = new TreeNode(20, new TreeNode(15), new TreeNode(7));

        SolutionRecursive recursive = new SolutionRecursive();
        SolutionBFS bfs = new SolutionBFS();

        Console.WriteLine("Recursive DFS Depth: " + recursive.MaxDepth(root));
        Console.WriteLine("BFS Depth: " + bfs.MaxDepth(root));
    }
}
