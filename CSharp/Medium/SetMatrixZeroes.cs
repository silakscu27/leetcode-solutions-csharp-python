// Problem: Set Matrix Zeroes
// Link: https://leetcode.com/problems/set-matrix-zeroes/
//
// Task:
// Given an m x n matrix, if an element is 0, set its entire row and column to 0.
// Do it in-place without using extra space for another matrix.
//
// Example:
// Input: 
// matrix = [
//  [1,1,1],
//  [1,0,1],
//  [1,1,1]
// ]
// Output:
// [
//  [1,0,1],
//  [0,0,0],
//  [1,0,1]
// ]

using System;
using System.Collections.Generic;

public class SetMatrixZeroesSolutions
{
    // ------------------------------------------------------------
    // ⚡ Solution: Using Sets to Track Rows and Columns
    // ------------------------------------------------------------
    // Time Complexity: O(m*n)
    // Space Complexity: O(m+n)
    // Explanation:
    //   - First pass: identify rows and columns that contain zero
    //   - Second pass: set all elements in these rows and columns to zero
    // ------------------------------------------------------------
    public static void SetZeroes(int[][] matrix)
    {
        int m = matrix.Length;
        int n = matrix[0].Length;

        HashSet<int> rows = new HashSet<int>();
        HashSet<int> cols = new HashSet<int>();

        // First pass: record rows and columns to zero
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i][j] == 0)
                {
                    rows.Add(i);
                    cols.Add(j);
                }
            }
        }

        // Second pass: update the matrix
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (rows.Contains(i) || cols.Contains(j))
                {
                    matrix[i][j] = 0;
                }
            }
        }
    }

    // ------------------------------------------------------------
    // 🧪 Test Section
    // ------------------------------------------------------------
    public static void Main()
    {
        int[][] matrix = new int[][]
        {
            new int[] {1,1,1},
            new int[] {1,0,1},
            new int[] {1,1,1}
        };

        SetZeroes(matrix);

        Console.WriteLine("Matrix after setting zeroes:");
        foreach (var row in matrix)
        {
            Console.WriteLine("[" + string.Join(", ", row) + "]");
        }
    }
}
