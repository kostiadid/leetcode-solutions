class Solution:
    def searchInsert(self, nums: List[int], target: int) -> int:        
        index = 0
    
        for i in range(len(nums)):
            if target == nums[i] :
                return i

        for y in range(len(nums)):
            if target > nums[y] :
                index+=1
        
        return index

        
