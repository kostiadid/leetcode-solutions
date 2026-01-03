from collections import defaultdict

class Solution:
    def countGoodSubstrings(self, s: str) -> int:
        my_dict = defaultdict(int)
        left = 0
        counter=0
        for i in range(len(s)):
            my_dict[s[i]] += 1
            if i - left == 3:
                my_dict[s[left]] -=1
                if  my_dict[s[left]] == 0: del  my_dict[s[left]] 
                left+=1
            if len(my_dict) == 3:
                counter+=1
        return counter 
               
                    
