// 219. Contains Duplicate II        Easy

// Given an array of integers and an integer k, find out whether there are two distinct indices i and j in the array such that nums[i] = nums[j] and the absolute difference between i and j is at most k.

// Example 1:

// Input: nums = [1,2,3,1], k = 3
// Output: true
// Example 2:

// Input: nums = [1,0,1,1], k = 1
// Output: true
// Example 3:

// Input: nums = [1,2,3,1,2,3], k = 2
// Output: false

using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode{
    public partial class ContainsDuplicate{

        /// <summary>
        /// 理论上可行，
        /// LeetCode 上测试超时 nums.length=50000  k=35000....
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public bool ContainsNearbyDuplicate_1(int[] nums, int k) {
            if(k==0||nums==null||nums.Length<=1) return false;
            Queue<int> q = new Queue<int>(k);
            for (int i = 0; i < nums.Length;i++){
                if(q.Contains(nums[i])) return true;
                if(q.Count==k){
                    q.Dequeue();
                }
                q.Enqueue(nums[i]);
            }
            return false;
        }

        /// <summary>
        /// 使用HashSet替代Queue ， 查找元素快  、添加、删除元素 ，效率提高了不少啊 
        /// 104 ms, faster than 94.62%
        /// 25.3 MB, less than 100.00%
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public bool ContainsNearbyDuplicate_1_2(int[] nums, int k) {
            if(k==0||nums==null||nums.Length<=1) return false;
            HashSet<int> q = new HashSet<int>(k);
            for (int i = 0; i < nums.Length; i++)
            {
                if (q.Contains(nums[i])) return true;
                if (q.Count == k)
                {
                    q.Remove(nums[i - k]);
                }
                q.Add(nums[i]);
            }
            return false;
        }
    }
}