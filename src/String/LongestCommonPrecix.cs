// Write a function to find the longest common prefix string amongst an array of strings.
// If there is no common prefix, return an empty string "".
//
// Example 1:
// Input: ["flower","flow","flight"]
// Output: "fl"
//
// Example 2:
// Input: ["dog","racecar","car"]
// Output: ""
// Explanation: There is no common prefix among the input strings.
// Note:
// All given inputs are in lowercase letters a-z.
using System;

namespace LeetCode{
    class LongestCommonPrefix{
        public string test(string[] strs) {
            if(strs.Length==0) return "";
            int minL=Int32.MaxValue;
            foreach(var str in strs){
                if(minL>str.Length)
                    minL=str.Length;
            }
            if(minL==0) return "";
            char[] cs=new char[minL];
            int j=0;
            for(;j<minL;j++){
                cs[j]=strs[0][j];
                foreach(var s in strs){
                    if(s[j]!=cs[j]) 
                        goto done;
                }
            }
            done:
            return new string(cs,0,j);
        }
    }
}
//
// Runtime: 100 ms, faster than 96.05% of C# online submissions for Longest Common Prefix.
// Memory Usage: 22.3 MB, less than 87.80% of C# online submissions for Longest Common Prefix.