# 1 Count zeros, ones and twos.
# 2 Create your own index and when accessing it, add each element as many times as we counted it from 0 to 2
# 3 At each iteration, increase our index by one to move to the next element in order

class Solution:
    def sortColors(self, nums: List[int]) -> None:
    #   nums.sort()       =)
        zero = one = other = 0

        for i in nums:
            if i == 0:
                zero += 1
            elif i == 1:
                one += 1
            else:
                other += 1

        midl = zero + one
        allv = midl + other

        v = 0
        while v < zero:
            nums[v] = 0
            v += 1
        while v < midl:
            nums[v] = 1
            v += 1
        while v < allv:
            nums[v] = 2
            v += 1
        
