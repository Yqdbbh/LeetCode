// 119. Pascal's Triangle II  Easy

// Given a non-negative index k where k ≤ 33, return the kth index row of the Pascal's triangle.

// Note that the row index starts from 0.

// In Pascal's triangle, each number is the sum of the two numbers directly above it.

// Example:

// Input: 3
// Output: [1,3,3,1]
// Follow up:

// Could you optimize your algorithm to use only O(k) extra space?
using System;
using System.Collections.Generic;

namespace LeetCode
{
    /// <summary>
    /// 杨辉三角 第二部分
    /// </summary>
    public partial class PascalTriangle
    {
        /// <summary>
        /// 输出杨辉三角第n行
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <returns></returns>
        public IList<int> GetRow(int rowIndex)
        {
            if(rowIndex ==0) return new int[1] { 1 };
            if(rowIndex ==1) return new int[2] { 1, 1 };
            var preRow = GetRow(rowIndex - 1);
            var res = new int[rowIndex + 1];
            res[0] = 1;
            for (var i = 1; i < rowIndex;i++){
                res[i] = preRow[i - 1] + preRow[i];
            }
            res[rowIndex] = 1;
            return res;
        }

        /// <summary>
        /// 获取前一行的数据，同样是递归，这个就可以通过，Fun不能通过，难道是因为Fun里调用了两次？？？
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <returns></returns>
        public IList<int> GetPreRow(int rowIndex){
            //var preRow = new List<int>();
            if(rowIndex==0) return new int[1] { 1 };
            if(rowIndex==1) return new int[2] { 1, 1, };
            var preRow = GetPreRow(rowIndex-1);
            var res = new int[rowIndex+1];
            res[0] = 1;
            for (var i = 1; i < rowIndex;i++){   
                res[i] = preRow[i - 1] + preRow[i];
            }
            res[rowIndex] = 1;
            return res;
        }

        /// <summary>
        /// 理论可行，实际上运行太慢，数字稍微大一点直接超时
        /// </summary>
        /// <param name="r">所在行</param>
        /// <param name="i">所在列</param>
        /// <returns></returns>
        public int Fun(int r,int i){
            // 0 0 1
            // 1 0 1
            // 1 1 1
            // 2 0 1
            // 2 1 f(1,0)+f(1,1)=1+1=2
            // 2 2 f(1,1)+f(1,2)=1+0=1
            // 3 0 1
            // 3 1 f(2,0)+f(2,1)=1+2=3
            // 3 2 f(2,1)+f(2,2)=2+1=3
            // 3 3 f(2,2)+f(2,3)=1+0=1
            if(i<1){
                return 1;
            }
            if(r<i) return 0;
            return Fun(r - 1, i - 1) + Fun(r - 1, i);
        }

    #region 失败，乘法
        /// <summary>
        /// 组合  
        /// C(3,0)=3*2*1/3!*0!=1
        /// C(3,1)=3*2*1/2*1*1=3  
        /// C(3,2)=3*2*1/1*2=3
        /// C(3,3)=3*2*1/0!*3!=1
        ///  超出整形最大长度，溢出，错误。
        ///  [1,31,465,4495,31465,169911,736281,2629575,7888725,20160075,44352165,84672315,141120525,206253075,265182525,300540195,300540195,265182525,206253075,141120525,84672315,44352165,20160075,7888725,2629575,736281,169911,31465,4495,465,31,1]
        /// [1,0,0,2,0,0,3,0,0,11,0,0,-1,0,0,-1,-1,0,0,-1,0,0,11,0,0,3,0,0,2,0,0,1]
        /// /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns>(m!)/((m-n)!*n!)</returns>
        private int C(int m,int n){
            
            int res = 1;
            int tmp1 = 1;
            int min = Math.Min(n, m - n);
            for (int i = 1; i <=min ;i++){
                res *= i;
            }
            tmp1 = res;
            int max = Math.Max(n, m - n);
            int tmp2;
            for (int i = min+1; i <= max;i++){
                res *= i;
            }
            tmp2 = res;
            for (int i = max+1; i <= m;i++){
                res *= i;
            }
            return res/(tmp1*tmp2);
        }

    #endregion

    }
}