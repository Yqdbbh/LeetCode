// 36 SearchInsertPosition
// Given a sorted array and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

// You may assume no duplicates in the array.

// Example 1:

// Input: [1,3,5,6], 5
// Output: 2
// Example 2:

// Input: [1,3,5,6], 2
// Output: 1
// Example 3:

// Input: [1,3,5,6], 7
// Output: 4
// Example 4:

// Input: [1,3,5,6], 0
// Output: 0
// Hbbdqy 2019-04-16
using System;
namespace LeetCode
{
    class SearchInsertPosition{
        public int test(int[] nums, int target) {
            if(nums.Length==0||target<nums[0]) return 0;
            int i=0;
            for(;i<nums.Length;i++){
                if(nums[i]>=target) return i;
            }
            return i;
        }
    }
}
//Runtime: 92 ms, faster than 99.79% of C# online submissions for Search Insert Position.
//Memory Usage: 22.4 MB, less than 83.33% of C# online submissions for Search Insert Position.