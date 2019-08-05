// 136. Single Number   Easy

// Given a non-empty array of integers, every element appears twice except for one. Find that single one.

// Note:

// Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?

// Example 1:

// Input: [2,2,1]
// Output: 1
// Example 2:

// Input: [4,1,2,1,2]
// Output: 4

 using System;
using System.Linq;

namespace LeetCode
{
    /// <summary>
    /// 找出数组中不重复的数字，要求时间复杂度为O(n),不允许额外内存
    /// </summary>
    public class FindSingleNumber
    {
        /// <summary>
        /// my
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumber(int[] nums) {
            if(nums.Length==1) return nums[0];
            Array.Sort(nums); 
            for (int i = 0; i < nums.Length-1;i++){
                if(nums[i++]!=nums[i])
                    return nums[--i];
            }
            if(nums.Length%2==0){
                return 0;
            }
            return nums[nums.Length-1];
        }

        /// <summary>
        /// 其他方法 ，运用异或运算 
        /// https://leetcode.com/problems/single-number/discuss/43218/A-C-XOR-Solution
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumber2(int[] nums) {
            int x = 0;
            for (int i = 0; i < nums.Length; i++) x ^= nums[i];
            return x;
        }

        /// <summary>
        /// 使用LINQ，同第二种
        /// https://leetcode.com/problems/single-number/discuss/43254/Very-simple-c-solution-with-linq
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumber3(int[] nums){
            return nums.Aggregate( (a, b) => a ^ b);
        }
        
    }
}
