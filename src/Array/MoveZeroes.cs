// 283. Move Zeroes      Easy

// Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.

// Example:

// Input: [0,1,0,3,12]
// Output: [1,3,12,0,0]
// Note:

// You must do this in-place without making a copy of the array.
// Minimize the total number of operations.

using System;

namespace LeetCode{
    public partial class MoveZero{
        /// <summary>
        /// 将数组中0元素移至末尾，要求不允许复制数组，最小化移动，还要保持非0元素的相对位置
        /// 0 1 0 3 12      1 0 0 3 0 12    1 0 0 3 0 12
        /// 12 1 0 3 0      1 0 0 3 0 12    1 3 0 0 0 12
        /// 1 12 0 3 0      1 3 0 0 12
        /// 1 12 3 0 0      1 3 12 0 0
        /// 1 3 12 0 0 
        /// Runtime: 264 ms
        /// Memory Usage: 29.8 MB
        /// </summary>
        /// <param name="nums"></param>
        public void MoveZeroes(int[] nums) {
            int startZero = 0; 
            int zeroLen = 0; 
            for (var i = 0; i < nums.Length;i++){
                if(startZero+zeroLen==nums.Length) return;
                if(nums[i]==0){
                    if(zeroLen==0){
                        startZero = i;
                    }
                    zeroLen++;
                    continue;
                }
                if(zeroLen>0){
                    nums[startZero] = nums[i];
                    nums[i] = 0;
                    startZero++;
                }
            }
        }

        /// <summary>
        /// 更好看的解决方案，然而测试结果和上面的差不多。。。
        /// https://leetcode.com/problems/move-zeroes/discuss/72379/C-easy-move-O(n)
        /// Runtime: 268 ms
        /// Memory Usage: 29.8 MB
        /// </summary>
        /// <param name="nums"></param>
        public void MoveZeroes_2(int[] nums){
            if(nums==null || nums.Length==0) return;
            int startZero = 0;
            for (var i = 0; i < nums.Length;i++){
                if(nums[i]!=0){
                    if(startZero!=i){ 
                        nums[startZero] = nums[i];
                        nums[i] = 0;
                    }
                    startZero++;
                }
            }
        }
    }
}