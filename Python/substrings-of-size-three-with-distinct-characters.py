from collections import defaultdict

class Solution:
    def countGoodSubstrings(self, s: str) -> int:
        my_dict = defaultdict(int)
        left = 0
        counter=0
        for i in range(len(s)):
            my_dict[s[i]] += 1
            if i - left == 3:
                remove_el = s[left]
                my_dict[remove_el] -=1
                if  my_dict[remove_el] == 0: del  my_dict[remove_el] 
                left+=1
            if len(my_dict) == 3:
                counter+=1
        return counter 
               
                    
