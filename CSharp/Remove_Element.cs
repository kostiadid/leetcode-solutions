public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int x = 0;
        for(var i = 0;i < nums.Length;i++){
            if(nums[i] != val){
                nums[x] = nums[i];
                x++;
            }
        } return x;
    }
}
// 0 1 3 0 4 0 4 2  

// https://leetcode.com/problems/remove-element/description/?envType=problem-list-v2&envId=niqxdky2

// 27
