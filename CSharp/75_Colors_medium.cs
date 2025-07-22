public class Solution {
    public void SortColors(int[] nums) {
        int zero=0,one=0,other=0;
        foreach(int i in nums){
            if(i==0){zero++;}
            if(i==1){one++;}
            if(i==2){other++;}
        }
        int midl = zero + one;
        int all = midl + other;
        int v=0;     
        for( ; v<zero;v++){nums[v] = 0;}
        for( ; v<midl;v++){nums[v] = 1;}
        for( ; v<all;v++){nums[v] = 2;} 
  
//     int index = 0;

// for (int i = 0; i < zero; i++) nums[index++] = 0;
// for (int i = 0; i < one; i++)  nums[index++] = 1;
// for (int i = 0; i < other; i++) nums[index++] = 2;
    
      
    }
  
}
//🤡 
//  Array.Sort(nums); 
