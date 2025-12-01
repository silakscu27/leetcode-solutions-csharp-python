// Problem: Rotate Image
// Link: https://leetcode.com/problems/rotate-image/
//
// Task:
// Given an n x n 2D matrix, rotate it 90 degrees clockwise in-place.
//
// Example:
// Input: 
// matrix = [
//  [1,2,3],
//  [4,5,6],
//  [7,8,9]
// ]
// Output:
// [
//  [7,4,1],
//  [8,5,2],
//  [9,6,3]
// ]

using System;

public class RotateImageSolutions
{
    // ------------------------------------------------------------
    // ⚡ Solution: Transpose + Reverse
    // ------------------------------------------------------------
    // Time Complexity: O(n^2)
    // Space Complexity: O(1) extra space (in-place)
    // Explanation:
    //   - Step 1: Transpose the matrix (swap matrix[i][j] with matrix[j][i])
    //   - Step 2: Reverse each row
    // ------------------------------------------------------------
    public static void Rotate(int[][] matrix)
    {
        int n = matrix.Length;

        // Step 1: Transpose
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }

        // Step 2: Reverse each row
        for (int i = 0; i < n; i++)
        {
            Array.Reverse(matrix[i]);
        }
    }

    // ------------------------------------------------------------
    // 🧪 Test Section
    // ------------------------------------------------------------
    public static void Main()
    {
        int[][] matrix = new int[][]
        {
            new int[] {1,2,3},
            new int[] {4,5,6},
            new int[] {7,8,9}
        };

        Rotate(matrix);

        Console.WriteLine("Rotated Matrix:");
        foreach (var row in matrix)
        {
            Console.WriteLine("[" + string.Join(", ", row) + "]");
        }
    }
}
