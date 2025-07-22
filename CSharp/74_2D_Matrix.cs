public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        // int cols = matrix[0].Length;
        // int low = 0;
        // int high = matrix.Length-1;
        int cols = matrix[0].Length;
        int rows = matrix.Length;
        int low = 0;
        int high = rows * cols - 1;
        while(low <= high){
            int mid = (low + high)/2;   
            int midRow = mid/cols;
            int midCol = mid%cols;
            int midValue = matrix[midRow][midCol];
            if(target < midValue){high = mid - 1;}
            else if (target > midValue){low = mid + 1;} 
            else{return true;} 
        }  
        return false;
    }
//  if(matrix[midRow][midCol] < target){
//                 for (int i = midIndex; i < rows * cols; i++)
//                 {
//                     int row = i / cols;
//                     int col = i % cols;
//                     int val = matrix[row][col];
//                     v = val == target;
//                     if(val == target){return v;}
//                 }

//             } 
//                 else {
//                     for(int i = midIndex; i >= 0; i--)
//                     {
//                         int row = i / cols;
//                         int col = i % cols;
//                         int val = matrix[row][col];
//                         v =  val == target;
//                         if(val == target){return v;}
//                     }
//                 }
//         return v;
}



// public class Solution {
//     public bool SearchMatrix(int[][] matrix, int target) {
//         for(int i = 0; i < matrix.GetLength(0); i++){
//           for(int y = 0; y < matrix[i].Length;y++){
//             if(matrix[i][y] == target){return true;}
//           }
//         } return false;
//     }
// }




