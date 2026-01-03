class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        hash_table = {}
        for  i in  s:
            if  i not in  hash_table:
                hash_table[i]=i
        counter = 0
        counter_list = []
        for i in s:
            if i in hash_table:
                counter+=1
                del hash_table[i]
            else: 
                counter_list.append(counter)
                continue
            counter_list.append(counter)
        big_length = sorted(counter_list)[-1]
        return big_length
