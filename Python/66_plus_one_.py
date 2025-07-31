class Solution:
    def plusOne(self, digits: List[int]) -> List[int]:
        
        value = digits[-1] + 1
        digits[len(digits) -1] = value 

        for i in range(len(digits) - 1, 0, -1):
            if digits[i] >9 and i!= 0:
                digits[i] =0
                digits[i-1] += 1

        if digits[0] == 10:
            newD = [0] * (len(digits) + 1)
            for i in range(len(digits)):
                newD[i] = digits[i] 
            newD[len(newD) - 1] = 0 
            newD[0] = 1 
            return newD
        return digits
