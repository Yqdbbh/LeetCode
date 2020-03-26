// 190. Reverse Bits     Easy

// Reverse bits of a given 32 bits unsigned integer.

// Example 1:

// Input: 00000010100101000001111010011100
// Output: 00111001011110000010100101000000
// Explanation: The input binary string 00000010100101000001111010011100 represents the unsigned integer 43261596, so return 964176192 which its binary representation is 00111001011110000010100101000000.
// Example 2:
// Input: 11111111111111111111111111111101
// Output: 10111111111111111111111111111111
// Explanation: The input binary string 11111111111111111111111111111101 represents the unsigned integer 4294967293, so return 3221225471 which its binary representation is 10101111110010110010011101101001.

// Note:

// Note that in some languages such as Java, there is no unsigned integer type. In this case, both input and output will be given as signed integer type and should not affect your implementation, as the internal binary representation of the integer is the same whether it is signed or unsigned.
// In Java, the compiler represents the signed integers using 2's complement notation. Therefore, in Example 2 above the input represents the signed integer -3 and the output represents the signed integer -1073741825.
// Follow up:

// If this function is called many times, how would you optimize it?

using System;
namespace LeetCode
{
    public class ReverseBits
    {
         public uint ReverseBitm(uint n) {
            // 此时有隐式转换,uint-->long
            string bitStr = Convert.ToString(n, 2);
            if(bitStr.Length>32)
                bitStr = bitStr.Substring(bitStr.Length-32);
            else
                bitStr=bitStr.PadLeft(32, '0');
            char[] bits = bitStr.ToCharArray();
            Array.Reverse(bits);
            uint res = Convert.ToUInt32(new string(bits), 2);
            return res;
        }

        /// <summary>
        /// 直接操作二进制位，妙啊
        /// https://leetcode.com/problems/reverse-bits/discuss/54853/Most-Simple-C-Solution
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public uint reverseBits(uint n)
        {
            uint num = 0;
            for(int i = 0; i < 32; ++i){
                num <<= 1;
                num += n % 2;
                n >>= 1;
            }
            return num;
        }
    }
}
