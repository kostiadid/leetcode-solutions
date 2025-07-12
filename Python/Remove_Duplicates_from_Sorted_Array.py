class Solution:
    def removeDuplicates(self, nums: List[int]) -> int:
        x = 1
        for i in range(1,len(nums)):
            if nums[i]  !=  nums[i - 1]:
                nums[x] = nums[i]
                x+=1;     
        return x 

#https://leetcode.com/problems/remove-duplicates-from-sorted-array/?envType=problem-list-v2&envId=niqxdky2
