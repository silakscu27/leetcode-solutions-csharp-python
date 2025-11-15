// Problem: Spiral Matrix
// Link: https://leetcode.com/problems/spiral-matrix/
//
// Task:
// Given an m x n matrix, return all elements of the matrix in spiral order.
//
// Example:
// Input: matrix = [
//  [ 1, 2, 3 ],
//  [ 4, 5, 6 ],
//  [ 7, 8, 9 ]
// ]
// Output: [1,2,3,6,9,8,7,4,5]

using System;
using System.Collections.Generic;

public class SpiralMatrixSolutions
{
    // ------------------------------------------------------------
    //  Solution: Layer by Layer (Using Boundaries)
    // ------------------------------------------------------------
    // Time Complexity: O(m*n)
    // Space Complexity: O(1) extra space (excluding output list)
    // Explanation:
    //   - Use four pointers to keep track of the boundaries:
    //     top, bottom, left, right
    //   - Traverse top row, right column, bottom row, left column
    //   - After each traversal, shrink the corresponding boundary
    // ------------------------------------------------------------
    public static List<int> SpiralOrder(int[][] matrix)
    {
        List<int> result = new List<int>();
        if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
            return result;

        int top = 0;
        int bottom = matrix.Length - 1;
        int left = 0;
        int right = matrix[0].Length - 1;

        while (top <= bottom && left <= right)
        {
            // Traverse top row from left to right
            for (int col = left; col <= right; col++)
                result.Add(matrix[top][col]);
            top++;

            // Traverse right column from top to bottom
            for (int row = top; row <= bottom; row++)
                result.Add(matrix[row][right]);
            right--;

            // Traverse bottom row from right to left
            if (top <= bottom)
            {
                for (int col = right; col >= left; col--)
                    result.Add(matrix[bottom][col]);
                bottom--;
            }

            // Traverse left column from bottom to top
            if (left <= right)
            {
                for (int row = bottom; row >= top; row--)
                    result.Add(matrix[row][left]);
                left++;
            }
        }

        return result;
    }

    // ------------------------------------------------------------
    //  Test Section
    // ------------------------------------------------------------
    public static void Main()
    {
        int[][] matrix = new int[][]
        {
            new int[] {1,2,3},
            new int[] {4,5,6},
            new int[] {7,8,9}
        };

        List<int> spiral = SpiralOrder(matrix);
        Console.WriteLine("Spiral Order: [" + string.Join(", ", spiral) + "]");
    }
}
