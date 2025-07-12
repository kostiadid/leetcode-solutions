public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int x = 1 ;  // index if the  next unique elemen
        for(int i = 1; i < nums.Length; i++){
            if(nums[i] != nums[i-1])
            {
                nums[x] = nums[i];
                x++;              ///  if not unique we don't do any changes ,
                                  /// when a unique will  overwrite the element  on index x.
            }
        }
        return x;
    }
}
// https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/?envType=problem-list-v2&envId=niqxdky2
// 26
