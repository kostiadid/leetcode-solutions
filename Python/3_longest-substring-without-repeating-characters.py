class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        hash_table = {}
        counter_list = []
        counter = 0
        for i in s:
            if i in hash_table:
                counter_list.append(counter)
                keys_to_delete = []
                for key in hash_table:
                    keys_to_delete.append(key)
                    if key == i:
                        break
                for key in keys_to_delete:
                    del hash_table[key]
                    continue
                counter = len(hash_table)
            hash_table[i]=i
            counter+=1
        if counter > 0:
            counter_list.append(counter)

        big_length = max(counter_list) if counter_list else 0
        # big_length = sorted(counter_list)[-1] if counter_list else 0
        return big_length
