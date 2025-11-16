"""
Problem: Set Matrix Zeroes
Link: https://leetcode.com/problems/set-matrix-zeroes/

Task:
Given an m x n matrix, if an element is 0, set its entire row and column to 0.
Do it in-place without using extra space for another matrix.

Example:
Input: 
matrix = [
 [1,1,1],
 [1,0,1],
 [1,1,1]
]
Output:
[
 [1,0,1],
 [0,0,0],
 [1,0,1]
]
"""

def set_zeroes(matrix):
    if not matrix or not matrix[0]:
        return

    m, n = len(matrix), len(matrix[0])
    rows, cols = set(), set()

    # First pass: record rows and columns that need to be zeroed
    for i in range(m):
        for j in range(n):
            if matrix[i][j] == 0:
                rows.add(i)
                cols.add(j)

    # Second pass: set the recorded rows and columns to zero
    for i in range(m):
        for j in range(n):
            if i in rows or j in cols:
                matrix[i][j] = 0

# ------------------------------------------------------------
# Test Section
# ------------------------------------------------------------
if __name__ == "__main__":
    matrix = [
        [1,1,1],
        [1,0,1],
        [1,1,1]
    ]

    set_zeroes(matrix)
    print("Matrix after setting zeroes:")
    for row in matrix:
        print(row)
