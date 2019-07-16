using System;
using System.Collections.Generic;
using System.Text;

//Determine whether an integer is a palindrome.An integer is a palindrome when it reads the same backward as forward.

//Example 1:
//Input: 121
//Output: true

//Example 2:
//Input: -121
//Output: false
//Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.

//Example 3:
//Input: 10
//Output: false
//Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
namespace LeetCode
{
    class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            char[] src=x.ToString().ToCharArray();
            char[] res = new char[src.Length];
            Array.Copy(src, res, src.Length);
            Array.Reverse(src);
            return new string(src).Equals(new string(res));
        }
    }
}
