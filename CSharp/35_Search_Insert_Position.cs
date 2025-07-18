public class Solution {
    public int SearchInsert(int[] nums, int target) {
        
        var index = 0;
        
        for(var i = 0; i < nums.Length;i++){
            if(target == nums[i]){return i;}
        }

        for(var y = 0; y < nums.Length;y++){
            if(target > nums[y]){index++;}
        }

        return index;
    }
}
