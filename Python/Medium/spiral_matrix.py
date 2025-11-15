"""
Problem: Spiral Matrix
Link: https://leetcode.com/problems/spiral-matrix/

Task:
Given an m x n matrix, return all elements of the matrix in spiral order.

Example:
Input: matrix = [
 [ 1, 2, 3 ],
 [ 4, 5, 6 ],
 [ 7, 8, 9 ]
]
Output: [1,2,3,6,9,8,7,4,5]
"""

def spiral_order(matrix):
    if not matrix or not matrix[0]:
        return []

    result = []

    top, bottom = 0, len(matrix) - 1
    left, right = 0, len(matrix[0]) - 1

    while top <= bottom and left <= right:
        # Traverse top row from left to right
        for col in range(left, right + 1):
            result.append(matrix[top][col])
        top += 1

        # Traverse right column from top to bottom
        for row in range(top, bottom + 1):
            result.append(matrix[row][right])
        right -= 1

        # Traverse bottom row from right to left, if still within boundaries
        if top <= bottom:
            for col in range(right, left - 1, -1):
                result.append(matrix[bottom][col])
            bottom -= 1

        # Traverse left column from bottom to top, if still within boundaries
        if left <= right:
            for row in range(bottom, top - 1, -1):
                result.append(matrix[row][left])
            left += 1

    return result

# ------------------------------------------------------------
# Test Section
# ------------------------------------------------------------
if __name__ == "__main__":
    matrix = [
        [1,2,3],
        [4,5,6],
        [7,8,9]
    ]
    print("Spiral Order:", spiral_order(matrix))
