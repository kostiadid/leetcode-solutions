
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
