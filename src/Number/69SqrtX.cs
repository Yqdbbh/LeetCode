//69.Sqrt(x)
//Implement int sqrt(int x).

//Compute and return the square root of x, where x is guaranteed to be a non-negative integer.

//Since the return type is an integer, the decimal digits are truncated and only the integer part of the result is returned.

//Example 1:

//Input: 4
//Output: 2
//Example 2:

//Input: 8
//Output: 2
//Explanation: The square root of 8 is 2.82842..., and since
//             the decimal part is truncated, 2 is returned.
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _69SqrtX
    {
        /// <summary>
        /// 牛顿迭代法求平方根
        /// 假设a。欲求a的平方根，首先猜测一个值X1=a/2，然后根据迭代公式X（n+1）=（Xn+a/Xn）/2，算出X2，再将X2代公式的右边算出X3等等，直到连续两次算出的Xn和X（n+1）的差的绝对值小于某个值，即认为找到了精确的平方根
        /// 1. def X1=n/2; X(n+1)=(Xn+n/Xn)/2;
        ///     |X(n+1)-X(n)| < e  , return n;
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int test(int x)
        {
            if (x == 0) return 0;
            if (x < 4) return 1;
            decimal r = x/2, r2 = 0;
            while (true)
            {
                r2 = (r + x / r) / 2;
                if (-1 < r - r2 && r - r2 <1)
                    break;
                r = r2;
            }
            return (int)r2;
        }
    }
}

/// 更简单的答案
/// https://leetcode.com/problems/sqrtx/discuss/208293/C-beat-90
//public int MySqrt(int x) {
//int r = x;

//        if(r>46340)r=46340;

//        while(r* r>x)
//        {
//            r = (r+x/r)/2;
//        }

//        return r;
//    }