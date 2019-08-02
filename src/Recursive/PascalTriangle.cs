// 118. Pascal's Triangle    Easy
// 
// Given a non-negative integer numRows, generate the first numRows of Pascal's triangle.

// In Pascal's triangle, each number is the sum of the two numbers directly above it.

// Example:

// Input: 5
// Output:
// [
//      [1],  0!
//     [1,1], C(1,0) C(1,1)
//    [1,2,1],  C(2,0) C(2,1) C(2,2)
//   [1,3,3,1],
//  [1,4,6,4,1]
// ]

using System.Collections.Generic;

namespace LeetCode{

    /// <summary>
    /// 杨辉三角
    /// </summary>
    public partial class PascalTriangle{

        /// <summary>
        /// 给定一个非负整数 n ，生成杨辉三角的前 n 行
        /// </summary>
        /// <param name="numRows"></param>
        /// <returns></returns>
        public IList<IList<int>> Generate(int numRows) {
            IList<IList<int>> root =  NumRowsLE2(numRows);
            if (numRows <= 2) {
                return root;
            }
            for (int i = 2;i<numRows;i++){
                int[] tmp = new int[i+1]; // 定义数组长度
                // 对开头和结尾赋值
                tmp[0] = 1;tmp[i] = 1;
                // 循环，掐头去尾, 从数组第二个元素开始，循环到数组第n-1个元素
                for (int j = 1; j < i; j++){
                    tmp[j] = root[i - 1][j - 1] + root[i - 1][j];
                }
                root.Add(tmp);
            }
            return root;
        }

        /// <summary>
        /// 当行号小于等于2时,直接输出
        /// </summary>
        /// <param name="numRows"></param>
        /// <returns></returns>
        private IList<IList<int>> NumRowsLE2(int numRows){
            IList<IList<int>> root = new List<IList<int>>();
            numRows = numRows > 2 ? 2 : numRows;
            switch(numRows){
                case 2:
                    root.Insert(0,new int[] { 1, 1 });
                    goto case 1;
                case 1:
                    root.Insert(0,new int[] { 1 });
                    break;
                default:
                    break;
            }
            return root;
        }
    }
}

// Other Answer
// from https://leetcode.com/problems/pascals-triangle/discuss/232284/Pure-recursive-solution-causes-Time-Limit-it's-wrong.

// public class Solution {
//     public IList<IList<int>> Generate(int numRows) 
//     {
//         var ans = new List<IList<int>>();
//         for (var i = 0; i < numRows; i++)
//         {
//             ans.Add(new List<int>());
//             for (var j = 0; j <= i; j++)
//             {
//                 ans[i].Add(F(i, j));
//             }
//         }
//         return ans;
//     }
    
//     private int F(int i, int j)
//     {
//         if (j == 0 || j == i)
//         {
//             return 1;
//         }
//         return F(i - 1, j - 1) + F(i - 1, j);;
//     }
// }