/*
 * @lc app=leetcode.cn id=66 lang=csharp
 *
 * [66] 加一
 */

// @lc code=start
using System.Linq;
namespace LeetCode{
    public class Solution_66 {
        public int[] PlusOne(int[] digits) {
            int length=digits.Length;
            if(length==0){
                return new int[1]{1};
            }
            if(digits[length-1]==9){
                //digits[length-1]=0;
                var res=PlusOne(digits.Take(length-1).ToArray());
                var list=res.ToList();
                list.Add(0);
                return list.ToArray();
            }else{
                digits[digits.Length-1]+=1;
                return digits;
            }
        }
    }
}

// @lc code=end

