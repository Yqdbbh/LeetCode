// 268. Missing Number       Easy

// Given an array containing n distinct numbers taken from 0, 1, 2, ..., n, find the one that is missing from the array.

// Example 1:

// Input: [3,0,1]
// Output: 2
// Example 2:

// Input: [9,6,4,2,3,5,7,0,1]
// Output: 8
// Note:
// Your algorithm should run in linear runtime complexity. Could you implement it using only constant extra space complexity?

using System;
using System.Linq;
namespace LeetCode{

    public partial class MissingNumber{
        /// <summary>
        /// 给定一个从0开始的连续数组，找出其中的丢失的一位，要求时间复杂度O(n),空间复杂度O(1);
        /// 思路：求和相减， 完美！
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MissingNumber_0(int[] nums) {
            // 用 0 替换 n ，数组长度正好符合公式 (1+n)n/2
            int expect = (1 + nums.Length)*nums.Length>>1;
            // 求数组数据和
            int sum = nums.Sum();
            return expect-sum;
        }
    }

}