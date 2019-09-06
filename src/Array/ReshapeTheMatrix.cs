// 566. Reshape the Matrix       Easy
// In MATLAB, there is a very useful function called 'reshape', which can reshape a matrix into a new one with different size but keep its original data.

// You're given a matrix represented by a two-dimensional array, and two positive integers r and c representing the row number and column number of the wanted reshaped matrix, respectively.

// The reshaped matrix need to be filled with all the elements of the original matrix in the same row-traversing order as they were.

// If the 'reshape' operation with given parameters is possible and legal, output the new reshaped matrix; Otherwise, output the original matrix.

// Example 1:
// Input: 
// nums = 
// [[1,2],
//  [3,4]]
// r = 1, c = 4
// Output: 
// [[1,2,3,4]]
// Explanation:
// The row-traversing of nums is [1,2,3,4]. The new reshaped matrix is a 1 * 4 matrix, fill it row by row by using the previous list.
// Example 2:
// Input: 
// nums = 
// [[1,2],
//  [3,4]]
// r = 2, c = 4
// Output: 
// [[1,2],
//  [3,4]]
// Explanation:
// There is no way to reshape a 2 * 2 matrix to a 2 * 4 matrix. So output the original matrix.
// Note:
// The height and width of the given matrix is in range [1, 100].
// The given r and c are all positive.

using System;
using System.Collections.Generic;

namespace LeetCode{
    /// <summary>
    /// 转换矩阵，把原矩阵转换为r行c列的矩阵，如果可以，则返回转换之后的矩阵，否则，返回原始矩阵
    /// </summary>
    class ReshapeTheMatrix{
        /// <summary>
        /// 把所有元素取出来，然后再存进去，感觉有点耗时，占内存
        /// 竟然通过了，还以为会超时，
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="r"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public int[][] MatrixReshape(int[][] nums, int r, int c) {
            // 判断是否可以转换
            int r0 = nums.Length; // 原始矩阵的行
            int c0 = nums[0].Length; // 原始矩阵的列
            int count = r0 * c0;
            if( count > r * c) return nums;
            List<int> oData = new List<int>();
            // 遍历原始数组
            for (var i = 0; i < r0;i++){ // 原始行
                for (var j = 0; j < c0;j++){ // 原始列
                    oData.Add(nums[i][j]);
                }
            }

            List<int[] > res = new List<int[] >();

            try{
                int tmpCount;
                for (int i = 0; i < r;i++){
                    tmpCount = i * c;
                    if(tmpCount>oData.Count) break;
                    int[] tmp = new int[c];
                    oData.CopyTo(tmpCount, tmp, 0, c);
                    res.Add(tmp);
                }
            }catch{
                return nums;
            }
            
            return res.ToArray();
        }

        /// <summary>
        /// 其他答案 ，为什么我总感觉有问题？ 
        /// https://leetcode.com/problems/reshape-the-matrix/discuss/102518/C-%22beats-99.36%22-Solution
        /// 和上面的方法重载？ int[,]表示二维数组，int[][]表示交错数组（数组的数组） 不可隐式转换
        /// https://www.cnblogs.com/ILoveMyJob/p/9211102.html
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="r"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public int[,] MatrixReshape(int[,] nums, int r, int c) {
            var r2 = nums.GetLength(0);
            var c2 = nums.GetLength(1);
            // if dimensions don't align then return
            if (r2 *c2 != r * c) return nums;
            // create new matrix shape
            int[,] result = new int[r,c];
            // loop over all rows
            for(var i = 0; i < r2; i++){
                // loop over all columns
                for(var j = 0; j < c2; j++){
                    // position is L-to-R position with (0,0) as index 0.  multiply out by c2 as 
                    // that's the number of columns we've skipped by being in row i and add current row offset j
                    var position = (i*c2) + j;
                    // absolute position integer division by new column size, c, gives us new row number (floor assumed)
                    // absolute position mod column size, c, gives us offset into current row aka column #
                    result[position / c, position % c] = nums[i,j];
                }
            }
            return result;
        }
    }
}