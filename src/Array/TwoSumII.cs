// 167. Two Sum II - Input array is sorted   Easy

// Given an array of integers that is already sorted in ascending order, find two numbers such that they add up to a specific target number.

// The function twoSum should return indices of the two numbers such that they add up to the target, where index1 must be less than index2.

// Note:

// Your returned answers (both index1 and index2) are not zero-based.
// You may assume that each input would have exactly one solution and you may not use the same element twice.
// Example:

// Input: numbers = [2,7,11,15], target = 9
// Output: [1,2]
// Explanation: The sum of 2 and 7 is 9. Therefore index1 = 1, index2 = 2.

namespace LeetCode{
    public partial class TwoSum{
        /// <summary>
        /// 有序数组，找出两个元素，使其和为给定值,
        /// 双层for 循环，太慢了...
        /// 只比5%的人快。。。
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSumII(int[] numbers, int target) {
            int tmp;
            for (int i = 0; i < numbers.Length;i++){
                for (int j = i+1; j < numbers.Length;j++){
                    tmp = numbers[j] + numbers[i];
                    if(target< tmp) break;
                    if(target==tmp){
                        return new int[] { i + 1, j + 1 };
                    }
                }
            }
            return new int[] { 0, 1 };
        }

        /// <summary>
        /// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/discuss/299549/C-concise-and-straightforward
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        private int[] TwoSumII_II(int[] numbers, int target)
        {
            //0 2 7 11 15   
            int l = 0, r = numbers.Length - 1;
            while (true)
            {
                if (numbers[l] + numbers[r] == target)
                    break;
                else if (numbers[l] + numbers[r] > target)
                    r--;
                else
                    l++;
            }
            return new int[] { l + 1, r + 1 };
        }
    }
    }
}