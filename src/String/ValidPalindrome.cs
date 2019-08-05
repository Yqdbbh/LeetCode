// 125. Valid Palindrome   Easy
// Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.

// Note: For the purpose of this problem, we define empty string as valid palindrome.

// Example 1:

// Input: "A man, a plan, a canal: Panama"
// Output: true
// Example 2:

// Input: "race a car"
// Output: false

using System;
using System.Text.RegularExpressions;

namespace LeetCode{
    /// <summary>
    /// 判断一个给定字符串是否为回文串，忽略大小写，只考虑字母和数字
    /// </summary>
    public class ValidPalindrome{
        public bool IsPalindrome(string s) {
            if(string.IsNullOrWhiteSpace(s)) return true;
            Regex regex = new Regex("[^0-9a-zA-Z]");
            string res=regex.Replace(s, "").ToLower();
            if(res.Length<2) return true;
            for (int i = 0,j=res.Length-1; i < res.Length / 2;i++,j--){
                if(res[i]!=res[j]) return false;
            }
            return true;
        }

        #region 其他方法 妙啊 
        //https://leetcode.com/problems/valid-palindrome/discuss/154722/C-Solution-Using-RegEx
        
        // public bool IsPalindrome( string s ) 
        // {
        //     s = Regex.Replace( s, "[^a-zA-Z0-9]+", "", RegexOptions.Compiled ).ToLower();
        //     return s.Equals( strRev( s ) );
        // }
        
        // private string strRev( string s )
        // {
        //     char[] cArr = s.ToCharArray();
        //     Array.Reverse( cArr );
            
        //     return new string( cArr );
        // }
        #endregion
    }
}
