public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        for(int i = 0; i < matrix.GetLength(0); i++){
          for(int y = 0; y < matrix[i].Length;y++){
            if(matrix[i][y] == target){return true;}
          }
        } return false;
    }
}




