// 485. Max Consecutive Ones     Easy

// Given a binary array, find the maximum number of consecutive 1s in this array.

// Example 1:
// Input: [1,1,0,1,1,1]
// Output: 3
// Explanation: The first two digits or the last three digits are consecutive 1s.
//     The maximum number of consecutive 1s is 3.
// Note:

// The input array will only contain 0 and 1.
// The length of input array is a positive integer and will not exceed 10,000

using System;

namespace LeetCode{

    /// <summary>
    /// 求二进制数组中连续为1的最大长度
    /// 数组最大长度不超过10000，转成数字移位，会溢出
    /// 直接循环+1好了
    /// </summary>
    public class MaxConsecutiveOnes{
        public int FindMaxConsecutiveOnes(int[] nums) {
            if(nums==null||nums.Length==0) return 0;  
            int max=0;
            int tmp=0;
            foreach(var i in nums){
                if(i==1){
                    tmp++;
                }else{
                    max = Math.Max(max, tmp);
                    tmp = 0;
                }
            }
            return Math.Max(max,tmp);
        }

        // 其他方法：想法很奇特 sum(sum(n)*nums[n]) 
        // https://leetcode.com/problems/max-consecutive-ones/discuss/96815/Very-Simple-c-No-%22if%22-%22else%22-used-no-string-concat-used
    }
}

