class Solution:
    def threeSum(self, nums: List[int]) -> List[List[int]]:

        nums=sorted(nums)
        result = []
        for i in range(len(nums)):
            if i > 0 and nums[i] == nums[i-1]:
                continue
            left, right = i+1, len(nums)-1
            while left < right:
                s = nums[i] + nums[left] + nums[right]
                if s < 0:
                    left += 1
                elif s > 0:
                    right -= 1
                else:
                    result.append([nums[i], nums[left], nums[right]])

                    while left < right and nums[left] == nums[left+1]:
                        left += 1
                    while left < right and nums[right] == nums[right-1]:
                        right -= 1
                    left += 1
                    right -= 1
        return result

  
# class Solution:
#     def threeSum(self, nums: List[int]) -> List[List[int]]:
#         sorted_nums=sorted(nums)
#         result = []
#         lenght = len(sorted_nums)
#         for i in range(lenght):
#             for j in range(i+1,lenght):
#                 for k in range(j+1,lenght):
#                         next2 = sorted_nums[j]
#                         next3 = sorted_nums[k]
#                         # summury = sorted_nums[i] +  next2 + next3
#                         if sorted_nums[i] +  next2 + next3 == 0:
#                             # before_result = None
#                             before_result = [sorted_nums[i],next2,next3]
#                             if before_result not in result:
#                                 result.append(before_result)
#         return result    

#it's working but  need   ioptimize        On2  instead of  O n3 
