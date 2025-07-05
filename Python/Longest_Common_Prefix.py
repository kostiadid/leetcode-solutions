class Solution:
    def longestCommonPrefix(self, strs: List[str]) -> str:
        minLength =  len(strs[0])
        outp = ""
        for i in range(len(strs)):
            if minLength > len(strs[i]):
                minLength = len(strs[i])

        for i in range(minLength):
            firstChar = strs[0][i]
            for word in strs : 
                if word[i] != firstChar:
                    return outp
            outp+=firstChar
        return outp


# https://leetcode.com/problems/longest-common-prefix/?envType=problem-list-v2&envId=niqxdky2
# Write a function to find the longest common prefix string amongst an array of strings.

# If there is no common prefix, return an empty string "".

 

# Example 1:

# Input: strs = ["flower","flow","flight"]
# Output: "fl"
# Example 2:

# Input: strs = ["dog","racecar","car"]
# Output: ""
# Explanation: There is no common prefix among the input strings.
 
