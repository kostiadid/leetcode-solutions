public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int i = 0;i < nums.Length;i++)
        {
            for(int j =i+1; j < nums.Length;j++)
            {
                if(nums[i]+nums[j]==target)
              return new int[] { i, j };
            }
        } return null;
    }
}
// https://leetcode.com/problems/two-sum/submissions/1680872001
