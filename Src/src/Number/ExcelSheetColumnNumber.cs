// 171. Excel Sheet Column Number    Easy
// Given a column title as appear in an Excel sheet, return its corresponding column number.

// For example:

//     A -> 1
//     B -> 2
//     C -> 3
//     ...
//     Z -> 26
//     AA -> 27
//     AB -> 28 
//     ...
// Example 1:

// Input: "A"
// Output: 1
// Example 2:

// Input: "AB"
// Output: 28
// Example 3:

// Input: "ZY"
// Output: 701

using System;
using System.Linq;

namespace LeetCode{

    /// <summary>
    ///  字符转数字,26进制
    /// </summary>
    public class ExcelSheetColumnNumber{

        /// <summary>
        /// 26进制转10进制,这个必须吹一波 
        /// 内存占用 Memory Usage: 22.9 MB, less than 100.00% of C# online submissions for Excel Sheet Column Number. 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int TitleToNumber(string s) {
            if(string.IsNullOrEmpty(s)) return 0;
            s = s.ToUpper().Trim();
            int res = 0;
            int len = s.Length-1;
            for (var i = len; i >= 0;i--){
                res += (s[i] - 'A'+1)*((int)Math.Pow(26,len-i));
            }
            return res;
        }

        /// <summary>
        /// 其他答案,6的飞起
        /// https://leetcode.com/problems/excel-sheet-column-number/discuss/52271/1-line-C-use-linq
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int TitleToNumber2(string s) { return s.Aggregate(0, (n, c) => n * 26 + c - 0x40); }
    }
}