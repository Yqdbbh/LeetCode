// 198. House Robber       Easy
// You are a professional robber planning to rob houses along a street. Each house has a certain amount of money stashed, the only constraint stopping you from robbing each of them is that adjacent houses have security system connected and it will automatically contact the police if two adjacent houses were broken into on the same night.

// Given a list of non-negative integers representing the amount of money of each house, determine the maximum amount of money you can rob tonight without alerting the police.

// Example 1:

// Input: [1,2,3,1]
// Output: 4
// Explanation: Rob house 1 (money = 1) and then rob house 3 (money = 3).
//              Total amount you can rob = 1 + 3 = 4.
// Example 2:

// Input: [2,7,9,3,1]
// Output: 12
// Explanation: Rob house 1 (money = 2), rob house 3 (money = 9) and rob house 5 (money = 1).
//              Total amount you can rob = 2 + 9 + 1 = 12.

using System;

namespace LeetCode{
    public class HouseRobber{
        /// <summary>
        /// 求子数组的元素和的最大值，子数组的元素在原始数组中不相邻
        /// https://leetcode.com/problems/house-robber/discuss/304014/C-O(n)-time-and-O(1)-Space
        /// https://leetcode-cn.com/problems/house-robber/solution/hua-jie-suan-fa-198-da-jia-jie-she-by-guanpengchn/
        /// 
        /// 下面这个解释的更清楚
        /// https://www.acwing.com/solution/leetcode/content/270/
        /// (动态规划) O(n)O(n)
        /// 令f[i]表示盗窃了第i个房间所能得到的最大收益，g[i]表示不盗窃第i个房间所能得到的最大收益。
        /// f[i] = g[i - 1] + nums[i]，g[i] = max(f[i - 1], g[i - 1])。
        /// 初始值f[0] = nums[0], g[0] = 0，答案为max(f[n - 1], g[n - 1])。
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int Rob(int[] nums ) {
            if(nums.Length ==0) return 0;
            if(nums.Length ==1) return nums[0];
            int v1 = 0; 
            int v2 = 0; 
            int max; 
            for (int i = 0; i < nums.Length;i++){
                max = Math.Max(v1, nums[i] + v2); 
                v2 = v1;
                v1 = max;
            }
            return Math.Max(v2, v1);
        }
    }
}