// 561. Array Partition I        Easy
// Given an array of 2n integers, your task is to group these integers into n pairs of integer, say (a1, b1), (a2, b2), ..., (an, bn) which makes sum of min(ai, bi) for all i from 1 to n as large as possible.

// Example 1:
// Input: [1,4,3,2]

// Output: 4
// Explanation: n is 2, and the maximum sum of pairs is 4 = min(1, 2) + min(3, 4).
// Note:
// n is a positive integer, which is in the range of [1, 10000].
// All the integers in the array will be in the range of [-10000, 10000].

using System;
using System.Runtime.CompilerServices;

[assembly:InternalsVisibleTo("LeetCodeTest")]
namespace LeetCode{
    class ArrayPartitionI{
        // 使每组最小值尽可能的大，和最大
        public int ArrayPairSum(int[] nums) {
            if(nums==null || nums.Length==0) return 0;
            int n = nums.Length/2;
            Array.Sort(nums);
            int sum = 0;
            for (var i = 0;i<n;i++){
                sum+=nums[2*i];
            }
            return sum;
        }

        /// <summary>
        /// 用加法代替乘法
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int ArrayPairSum2(int[] nums) {
            if(nums==null || nums.Length==0) return 0;
            Array.Sort(nums);
            int sum = 0;
            for (var i = 0;i<nums.Length;i+=2){
                sum+=nums[i];
            }
            return sum;
        }
    }
}