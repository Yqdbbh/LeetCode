// 172. Factorial Trailing Zeroes    Easy
// Given an integer n, return the number of trailing zeroes in n!.

// Example 1:

// Input: 3
// Output: 0
// Explanation: 3! = 6, no trailing zero.
// Example 2:

// Input: 5
// Output: 1
// Explanation: 5! = 120, one trailing zero.
// Note: Your solution should be in logarithmic time complexity.
using System;

namespace LeetCode
{
    public class FactorialTrailingZeroes
    {
        /// <summary>
        /// 查看一个数的阶乘里最后有几个0
        /// https://leetcode.com/problems/factorial-trailing-zeroes/discuss/52380/C-solution%3A-count-for-5-because-the-number-of-2-much-more-than-5.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int TrailingZeroes(int n) {

            if (n <= 0) return 0;

            int count = 0;
            while (n > 0)
            {
                count += n / 5;
                n /= 5;
            }

		    return count;

            /// 
            /// 一开始就错了，不应该判断2、5、10的，直接判断5就可以了，白白浪费了一天时间
            /// 
            
            // int res = 0;
            // if(n<10){
            //     if(n>=5) return 1;
            //     else return 0;
            // }
            // while(n>=10){
            //     if(n%10==0){
            //         res += 2;
            //         n /= 10;
            //         continue;
            //     }
            //     res += (n/10 % 10) * 2;
            //     if(n%10>=5){
            //         res++;
            //     }
            //     n /= 10;
            // }
            // return res;
        }
    }
}
