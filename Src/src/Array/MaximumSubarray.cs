// 53. Maximum Subarray
// Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.
// 给定一个int类型数组，找出一个连续的子数组使得子数组元素中的和最大
// Example:

// Input: [-2,1,-3,4,-1,2,1,-5,4],
// Output: 6
// Explanation: [4,-1,2,1] has the largest sum = 6.
// Follow up:

// If you have figured out the O(n) solution, try coding another solution using the divide and conquer approach, which is more subtle.
/// <summary>
/// Hbbdqy  2019-04-17
/// </summary>
using System;
namespace LeetCode
{
    class MaximumSubarray
    {
        public int test(int[] nums) {
            int max=nums[0];
            int tmp;
            for(int i=0;i<nums.Length;i++){
                tmp=nums[i];
                for(int j=1;j<nums.Length-i;j++){
                    if(max<tmp) max=tmp;
                    tmp+=nums[i+j];
                }
                if(max<tmp) max=tmp;
            }
            return max;
        }
    }
}

//答案解析 具体可查看以下网址
//https://leetcode.com/problems/maximum-subarray/discuss/20188/C-Solution-using-stateful-DP-O(N)-complexity-O(1)-Space

// In this problem, the recurrence relation, itself, is dynamic and has two states: 1) if the running sum is > 0, then sum = sum + Ai, 2) if the running sum is < 1, the sum is reset to Ai. In this way, it is a "stateful" DP problem (an atypical memoization that does not require an array for tracking states of each n)--it is a running state that, itself, is dynamic.

// So, the real "elephant" in the room is that any value < 1 changes the state? To answer that question, let's consider the behavior. If we use the "vector" language, any time the vector direction changes, the co-related state changes. We can consider each contiguous sub-array it's own vector. Whenever the running sum changes direction, that implies that we are starting a new vector and/or terminating the current vector.

// There are 3 states for the running sum vector:

// Moving in a positive direction
// Moving in a negative direction
// Not moving
// For calculating the Maximum, we are concerned with the positive direction. We want the value of the vector (sub-array) with the maximum amplitude (sum). Each Ai that is greater than 0, automatically has greater amplitude than any vector, whose direction is not moving and/or negative. The key here is that an element Ai, that behaves this way, gives us a way to make a stateful DP.

// Examples:

// {2, -1 , 3} = 4; //The direction never changed
// {1, -2, 3} = 3 //The direction changed at Ai = 3 (or {1, -2} is a negative vector)
// {-1, 0, 0, 0) = 0 //The direction changed at Ai = 0
// {-1, -2, -3, -4} = -1 //The direction never changed, but note that element Ai=-1 is the max
// There already solutions done this way, but without adequate explanation in my honest opinion.

// Without further adieu here is the stateful DP code that I used that resulted in O(N) complexity with O(1) space:
// public int MaxSubArray(int[] nums)
//     {
//         int maxSum = 0;
//         int length = nums.Length;
        
//         if (length > 0)
//         {
//             int sum = maxSum = nums[0];

//             for(int i = 1; i < length; i++)
//             {
//                 if(sum > 0)
//                 {
//                     sum += nums[i];
//                 }
//                 else
//                 {
//                     sum = nums[i];
//                 }

//                 if(sum > maxSum)
//                 {
//                     maxSum = sum;
//                 }
//             }
//         }

//         return maxSum;
//     }
/// {-2,1,-3,4,-1,2,1,-5,4};
/// i       e       csum    maxSum
/// 0       -2      -2      -2
/// 1       1       1       1
/// 2       -3      -2      1
/// 3       4       4       4
/// 4       -1      3       4
/// 5       2       5       5
/// 6       1       6       6
/// 7       -5      1       6
/// 8       4       5       6