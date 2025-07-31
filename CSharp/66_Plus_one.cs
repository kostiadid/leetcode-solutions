public class Solution {
    public int[] PlusOne(int[] digits) {
        int value = digits[digits.Length -1] + 1;
        digits[digits.Length -1] = value ;

        for(var i = digits.Length -1; i>0;i--){
            if(digits[i] >9 && i!= 0){
                digits[i] =0;
                digits[i-1] += 1; 
            }
            // else if (digits[i] == 0) {
            //     return new int[] {1, 0};
            // }

        } if (digits[0] == 10){
           int[] newD = new int[digits.Length + 1];
           for (int i = 0; i < digits.Length; i++)
            {
                newD[i] = digits[i]; 
            }
            newD[newD.Length - 1] = 0; 
            newD[0] = 1; 
            return newD;
        }
        return digits;
    }
}

        // int lastI = digits.Length -1;
        // int lastIB = lastI -1;
        // int value = digits[lastI] + 1;

        // digits[lastI] = value ;

        // if(digits[lastI] >9 && lastI!= 0){
        //     digits[lastIB] +=1;
        //     digits[lastI] = 0; 
        //     }
        //     else if (lastI == 0) {
        //     return new int[] {1, 0};
        // }
        // return digits;
