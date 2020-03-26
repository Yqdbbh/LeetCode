// 169. Majority Element  Easy
// Given an array of size n, find the majority element. The majority element is the element that appears more than ⌊ n/2 ⌋ times.

// You may assume that the array is non-empty and the majority element always exist in the array.

// Example 1:
// Input: [3,2,3]
// Output: 3

// Example 2:
// Input: [2,2,1,1,1,2,2]
// Output: 2

using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class MajorityElement
    {
        public int Majority(int[] nums) {
            Dictionary<int,int> times = new Dictionary<int,int>();
            foreach(int item in nums){
                if(times.ContainsKey(item)){
                    times[item]++;
                }else{
                    times.Add(item, 1);
                }
            }
            var maxTime = times.Max(item => item.Value);
            foreach(var item in times){
                if(item.Value==maxTime)
                    return item.Key;
            }
            return nums[0];
        }

        /// <summary>
        /// 更优解,不需要循环完毕,在循环过程中如果元素个数大于n/2 则直接返回 , 仅在本题种生效,题目规定 
        /// The majority element is the element that appears more than ⌊ n/2 ⌋ times
        /// https://leetcode.com/problems/majority-element/discuss/51929/C-Dictionary(HashTable)-Solution
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MajorityII(int[] nums){
            int n = nums.Length;
            Dictionary<int, int> count = new Dictionary<int, int>();
            for(int i = 0; i < n; i++)
            {
                if(count.ContainsKey(nums[i]))
                    count[nums[i]]++;
                else
                    count.Add(nums[i], 1);
                if(count[nums[i]] > n/2) return nums[i];
            }
            return int.MaxValue;
        }
    }
}
