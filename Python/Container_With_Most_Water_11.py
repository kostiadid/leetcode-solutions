class Solution:
    def maxArea(self, height: List[int]) -> int:
        left = 0
        right = len(height) - 1
        s = []
        while left < right:
            for i in  height:
                if height[left] < height[right]:
                    left+=1
                if height[left] > height[right]:
                    right-=1
            h = min(height[left], height[right])
            w = right - left
            s.append(h * w)
        
        return max(s)


            
