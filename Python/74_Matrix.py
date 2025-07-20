class Solution:
    def searchMatrix(self, matrix: list[list[int]], target: int) -> bool:
        for i in range(len(matrix)):
            for y in range(len(matrix[i])):
                if matrix[i][y] == target:
                    return True
        return False
