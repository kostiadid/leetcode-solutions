// Write a function to find the longest common prefix string amongst an array of strings.
// If there is no common prefix, return an empty string "".

// Example 1:

// Input: strs = ["flower","flow","flight"]
// Output: "fl"
// Example 2:

// Input: strs = ["dog","racecar","car"]
// Output: ""
// Explanation: There is no common prefix among the input strings.
 // https://leetcode.com/problems/longest-common-prefix/description/?envType=problem-list-v2&envId=niqxdky2
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
       int minLength =  strs[0].Length;
       string outp = "";
       for(int i = 1; i < strs.Length; i++){
            if (minLength > strs[i].Length)
            {
                minLength = strs[i].Length;
            }
       }
       for(int i = 0;i < minLength; i++)
        {
         char firstChar = strs[0][i];
            foreach (string word in strs) 
            {
                if (word[i] != firstChar)
                {
                    return outp;
                }
            } 
                outp+=firstChar;

        } return outp;

    }
}
