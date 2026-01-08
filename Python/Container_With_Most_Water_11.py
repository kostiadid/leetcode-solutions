class Solution:
    def maxArea(self, height: List[int]) -> int:
        right = 0
        left = 0
        while right < len(height):
            for i in  height:
                if height[i] > right:
                    right = height[i]
            for j in reversed(height):
                if height[i] > left:
                    left = height[i]
