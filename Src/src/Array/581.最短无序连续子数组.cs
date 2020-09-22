/*
 * @lc app=leetcode.cn id=581 lang=csharp
 *
 * [581] 最短无序连续子数组
 */
 
namespace LeetCode{
    // @lc code=start
    using System;
    public class Solution_581 {
        public int FindUnsortedSubarray(int[] nums) {
            int[] source=nums.Clone() as int[];
            Array.Sort(source);
            int head=0,tail=0;
            for(var i=0;i<nums.Length;i++){
                if(source[i]!=nums[i]){
                    head=i;
                    break;
                }
            }
            
            for(var i=nums.Length-1;i>=head;i--){
                if(source[i]!=nums[i]){
                    tail=i;
                    break;
                }
            }
            return head==tail?0:tail-head+1;
        }
    }
    // @lc code=end
}

