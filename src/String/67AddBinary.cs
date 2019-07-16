// 67. AddBinary
// Given two binary strings, return their sum (also a binary string).

// The input strings are both non-empty and contains only characters 1 or 0.

// Example 1:

// Input: a = "11", b = "1"
// Output: "100"
// Example 2:

// Input: a = "1010", b = "1011"   
// Output: "10101"
using System;
using System.Text;
namespace LeetCode
{
    class AddBinary
    {
        public string test(string a, string b) {
            StringBuilder sb = new StringBuilder();
            int len = Math.Min(a.Length, b.Length);
            int alen = a.Length;
            int blen = b.Length;
            int h = 0;
            int ai = 0,bi=0;
            while (alen > 0 && blen > 0)
            {
                ai = a[--alen] - '0';
                bi = b[--blen] - '0';
                int r = (~((ai & ~bi) | (~ai & bi)) & h) | (~h & ((ai & ~bi) | (~ai & bi)));
                sb.Insert(0, r);
                h = (ai & bi) | (ai & h) | (bi & h);
            }
            if (h != 0)
            {
                while (alen > 0)
                {
                    ai = a[--alen] - '0';
                    sb.Insert(0, (ai & ~h) | (~ai & h));
                    h = ai & h;
                }
                while (blen > 0)
                {
                    bi = b[--blen] - '0';
                    sb.Insert(0, (bi & ~h) | (~bi & h));
                    h = bi & h;
                }
                if (h != 0)
                {
                    sb.Insert(0, h);
                }
            }
            else
            {
                while (alen > 0)
                {
                    sb.Insert(0, a[--alen]);
                }
                while (blen > 0)
                {
                    sb.Insert(0, b[--blen]);
                }
            }
            return sb.ToString();
        }  
    }    
}
/// 1010 1011            
/// a[i]    b[i]    r[i]    h
/// 0       1       1       0
/// 1       1       0       1
/// 0       0       1       0
/// 1       1       0       1
/// 0       0       1       0
/// 
/// r[i]=(a[i] xor b[i]) xor h[i-1]; 
/// h[i]=a&b;
/// a[i]    b[i]    r[i]    h
/// 1       0       1       0
/// 1       0       1       0
/// 1       1       0       1
/// 1       1       1       1
/// 0       1       0       1

/// 下面是写的漂亮的答案
//public string AddBinary(string a, string b)
//{
//    StringBuilder sb = new StringBuilder();
//    int carry = 0;
//    for (int i = a.Length - 1, j = b.Length - 1; i >= 0 || j >= 0; i--, j--)
//    {
//        int total = ((i >= 0 ? a[i] - '0' : 0) + (j >= 0 ? b[j] - '0' : 0)) + carry;
//        sb.Insert(0, total == 2 || total == 0 ? '0' : '1');
//        carry = total > 1 ? 1 : 0;
//    }
//    return carry == 1 ? sb.Insert(0, 1).ToString() : sb.ToString();
//}
