// 58. Length of Last Word
// Given a string s consists of upper/lower-case alphabets and empty space characters ' ', return the length of last word in the string.

// If the last word does not exist, return 0.

// Note: A word is defined as a character sequence consists of non-space characters only.

// Example:

// Input: "Hello World"
// Output: 5
using System;
namespace LeetCode
{
    public class LengthOfTheLastWord{
        public int test(string s) {
            if(!string.IsNullOrEmpty(s)){
                s=s.TrimEnd();
                return s.Length-s.LastIndexOf(' ')-1;
                // s=System.Text.RegularExpressions.Regex.Replace(s.Trim(),"s+","s");
                // string[] strs=s.Split(' ');
                // return strs[strs.Length-1].Length;
            }
            return 0;
        } 
    }
}
///Runtime: 72 ms, faster than 99.84% of C# online submissions for Length of Last Word.
///Memory Usage: 20.1 MB, less than 70.21% of C# online submissions for Length of Last Word.
