//70. Climbing Stairs
//You are climbing a stair case. It takes n steps to reach to the top.

//Each time you can either climb 1 or 2 steps.In how many distinct ways can you climb to the top?

//Note: Given n will be a positive integer.

//Example 1:

//Input: 2
//Output: 2
//Explanation: There are two ways to climb to the top.
//1. 1 step + 1 step
//2. 2 steps
//Example 2:

//Input: 3
//Output: 3
//Explanation: There are three ways to climb to the top.
//1. 1 step + 1 step + 1 step
//2. 1 step + 2 steps
//3. 2 steps + 1 step
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ClimbingStairs
    {
        /// <summary>
        /// n阶楼梯，每次走1阶或两阶，求有多少种走法。设为f(n)种
        /// 假设还有2步到顶，则有两种选择，1.最后一步选择走1步--->f(n-1)，2.最后一步走2步---->f(n-2);
        /// 依次类推：
        ///     n>2：f(n)=f(n-1)+f(n-2);
        ///     n=2: f(2)=f(1)+f(0) = 2; ==>f(0)=1;
        ///     n=1: f(1)=1;
        ///     f(n)=f(n-1)+f(n-2)=f(n-2)+f(n-4)+f(n-3)+f(n-4)=.....
        ///                              (n)
        ///                 (n-1)          +        (n-2)
        ///             (n-2) + (n-3)           (n-3)   +   (n-4) 
        ///       (n-3)+(n-4)  (n-4)+(n-5)  (n-4)+(n-5)   (n-5)+(n-6)  
        ///       
        ///  右边的每个分支的值都是左边分支的子分支，
        ///  所以最终递归到f(2)和f(1)
        ///  ------>斐波那契数列  1 1 2 3 ....
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int test(int n)
        {
            if (n < 2) return 1;
            if (n == 2) return 2;
            int f1 = 1,f2 = 2;
            for(int i = 2; i < n; i++)
            {
                f2 = f1 + f2;
                f1 = f2 - f1;
            }
            return f2;
        }
    }
}
//Runtime: 36 ms, faster than 100.00% of C# online submissions for Climbing Stairs.
//Memory Usage: 12.9 MB, less than 29.41% of C# online submissions for Climbing Stairs.
