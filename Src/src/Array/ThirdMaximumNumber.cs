// 414. Third Maximum Number     Easy
// Given a non-empty array of integers, return the third maximum number in this array. If it does not exist, return the maximum number. The time complexity must be in O(n).

// Example 1:
// Input: [3, 2, 1]
// Output: 1
// Explanation: The third maximum is 1.

// Example 2:
// Input: [1, 2]
// Output: 2
// Explanation: The third maximum does not exist, so the maximum (2) is returned instead.

// Example 3:
// Input: [2, 2, 3, 1]
// Output: 1
// Explanation: Note that the third maximum here means the third maximum distinct number.
// Both numbers with value 2 are both considered as second maximum.

using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode{
    /// <summary>
    /// 求非空数组中第三大的数，如果不存在，则返回最大值，重复的数字计算一次
    /// </summary>
    public class ThirdMaxMumNumber{
        /// <summary>
        ///  思路：
        ///     重复数字只计算一次，用hashSet去重，取第三大的数，排序取前三
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int ThirdMax(int[] nums) {
            if(nums.Length==0) return 0;
            if(nums.Length==1) return nums[0];
            if(nums.Length==2) return Math.Max(nums[0], nums[1]);

            HashSet<int> hs = new HashSet<int>(nums);
            var resList=hs.ToList().OrderByDescending(n=>n);
            
            if(resList.Count()<=2) return resList.First();
            else
                //return resList.Skip(2).First(); // 感觉如果数据量大的说，取前几个好点
                return resList.Take(3).Last();
        }
        //  速度还行，中规中举
        //  Runtime: 100 ms, faster than 73.06% of C# online submissions for Third Maximum Number.
        //  Memory Usage: 23.3 MB, less than 100.00% of C# online submissions for Third Maximum Number.
    }
}