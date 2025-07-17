// https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/description/?envType=problem-list-v2&envId=niqxdky2
// 28. Find the Index of the First Occurrence in a String

public class Solution {
    public int StrStr(string haystack, string needle) {
       
        // solution  num 1

        // if (needle == ""){return 0;};
        // if(haystack.Contains(needle)){
        //     return haystack.IndexOf(needle);
        // } else {return -1;}

        /// solution  num 2  // if  needle not found  we will return -1 
        // return haystack.IndexOf(needle);
        
        // solution  num 3    
        int needleLength = needle.Length;
        for(int i =0; i <= haystack.Length - needleLength;i++){
            var cake = haystack.Substring(i, needleLength);
            if(needle == cake) 
            {
                return i;
            }
        } 
        return -1;
    }
}
