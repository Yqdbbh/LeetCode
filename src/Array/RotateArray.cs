// 189. Rotate Array    Easy
// Given an array, rotate the array to the right by k steps, where k is non-negative.

// Example 1:

// Input: [1,2,3,4,5,6,7] and k = 3
// Output: [5,6,7,1,2,3,4]
// Explanation:
// rotate 1 steps to the right: [7,1,2,3,4,5,6]
// rotate 2 steps to the right: [6,7,1,2,3,4,5]
// rotate 3 steps to the right: [5,6,7,1,2,3,4]
// Example 2:

// Input: [-1,-100,3,99] and k = 2
// Output: [3,99,-1,-100]
// Explanation: 
// rotate 1 steps to the right: [99,-1,-100,3]
// rotate 2 steps to the right: [3,99,-1,-100]
// Note:

// Try to come up as many solutions as you can, there are at least 3 different ways to solve this problem.
// Could you do it in-place with O(1) extra space?

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class RotateArray
    {
        /// <summary>
        /// 利用序列
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        public void Rotate(int[] nums, int k) {
            Array.Reverse(nums);
            Queue<int> queue = new Queue<int>(nums);
            int tmp;
            for (int i = 0; i < k;i++){
                tmp=queue.Dequeue();
                queue.Enqueue(tmp);
            }
            queue.CopyTo(nums, 0);
            Array.Reverse(nums);
        }

        /// <summary>
        /// 虽然好看，但并不快
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        public void Rotate2(int[] nums,int k){
            k %= nums.Length;
            int[] tmp = new int[k];
            Array.Copy(nums, nums.Length - k, tmp, 0,k);
            Array.Copy(nums, 0, nums, k, nums.Length - k);
            Array.Copy(tmp, nums, k);
        }
    }
}
