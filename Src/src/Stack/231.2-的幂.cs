/*
 * @lc app=leetcode.cn id=231 lang=csharp
 *
 * [231] 2的幂
 *
 * https://leetcode-cn.com/problems/power-of-two/description/
 *
 * algorithms
 * Easy (47.80%)
 * Likes:    173
 * Dislikes: 0
 * Total Accepted:    51.3K
 * Total Submissions: 107.3K
 * Testcase Example:  '1'
 *
 * 给定一个整数，编写一个函数来判断它是否是 2 的幂次方。
 * 
 * 示例 1:
 * 
 * 输入: 1
 * 输出: true
 * 解释: 2^0 = 1
 * 
 * 示例 2:
 * 
 * 输入: 16
 * 输出: true
 * 解释: 2^4 = 16
 * 
 * 示例 3:
 * 
 * 输入: 218
 * 输出: false
 * 
 */
using System;
// @lc code=start
namespace LeetCode{
    public class Solution_231 {
        public bool IsPowerOfTwo(int n) {
            // 2的幂次方 0 1 2 4 8 
            // 二进制   0 10 100 1000
            // 只出现一个1
            if(n==1) return true;            
            bool onlyOne=false;
            while(n>0){
                if((n&1)==1){
                    if(onlyOne) 
                        return false;
                    
                    onlyOne=true;
                }
                n=n>>1; // 除二
            }
            n.ToString();
            return onlyOne;
        }
        
        // 直接转成二进制字符串,查找1的个数
        public bool IsPowerOfTwo2(int n){
            if(n<1) return false;
            string str=Convert.ToString(n,2);
            return str.Trim('0').Length==1;
        }
    }
}

// @lc code=end

