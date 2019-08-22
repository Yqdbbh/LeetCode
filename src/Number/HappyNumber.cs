// 202. Happy Number    Easy
// Write an algorithm to determine if a number is "happy".

// A happy number is a number defined by the following process: Starting with any positive integer, replace the number by the sum of the squares of its digits, and repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1. Those numbers for which this process ends in 1 are happy numbers.

// Example: 

// Input: 19
// Output: true
// Explanation: 
// 1^2 + 9^2 = 82
// 8^2 + 2^2 = 68
// 6^2 + 8^2 = 100
// 1^2 + 0^2 + 0^2 = 1

using System;
using System.Collections.Generic;

namespace LeetCode{

    /// <summary>
    /// 给定一个数，将其正数部分的每个数字求平方，然后求和，重复对和进行操作，直到结果为1，或无限循环，若和为1，则返回true;
    /// </summary>
    public class HapperNumber
    {

        public bool IsHappy(int n)
        {
            if (n < 1) return false;
            if (n == 1) return true;
            HashSet<int> hs = new HashSet<int>();
            int tmp;
            while (n != 1)
            {
                tmp = 0;
                if (hs.Contains(n)) return false;
                hs.Add(n);
                while (n > 0)
                {
                    tmp += (int)Math.Pow(n % 10, 2);
                    n /= 10;
                }
                if (tmp == 1) return true;
                n = tmp;
            }
            return false;
        } 
        /// faster than 7.03% , less than 33.33%  有点慢。。。
        /// 改进  (int)Math.Pow(n%10,2)  ----> (n%10)*(n%10)   faster than 93.73% ; less than 66.67%  
    }
}