"""
Problem: Rotate Image
Link: https://leetcode.com/problems/rotate-image/

Task:
Given an n x n 2D matrix, rotate it 90 degrees clockwise in-place.

Example:
Input: 
matrix = [
 [1,2,3],
 [4,5,6],
 [7,8,9]
]
Output:
[
 [7,4,1],
 [8,5,2],
 [9,6,3]
]
"""

def rotate(matrix):
    n = len(matrix)
    # Step 1: Transpose the matrix
    for i in range(n):
        for j in range(i+1, n):
            matrix[i][j], matrix[j][i] = matrix[j][i], matrix[i][j]

    # Step 2: Reverse each row
    for i in range(n):
        matrix[i].reverse()

# ------------------------------------------------------------
# Test Section
# ------------------------------------------------------------
if __name__ == "__main__":
    matrix = [
        [1,2,3],
        [4,5,6],
        [7,8,9]
    ]

    rotate(matrix)
    print("Rotated Matrix:")
    for row in matrix:
        print(row)
