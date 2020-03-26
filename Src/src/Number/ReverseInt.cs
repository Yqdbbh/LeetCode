using System;

//Given a 32-bit signed integer, reverse digits of an integer.

//Example 1:

//Input: 123
//Output: 321
//Example 2:

//Input: -123
//Output: -321
//Example 3:

//Input: 120
//Output: 21
//Note:
//Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.
#pragma warning disable 0168
namespace LeetCode
{
    public class ReverseInt{
        public int Reverse(int x) {
            Int64 r = 0;
            if (x >= Int32.MaxValue) return (int)r;
            bool f= false;
            // x = Math.Abs(x);  //-2147483648 溢出
            if (x < 0)
            {
                f = true;
                x = 0 - x;
            }
            char[] nums=(x+"").ToCharArray();
            for(int i = nums.Length - 1; i >= 0; i--)
            {
                r = r * 10 + nums[i]-48;
            }
            if (r > Int32.MaxValue) return 0;
            if (f) return -(int)r;
            return (int)r;
        }

        /// <summary>
        /// Best Answer
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int A_Reverse(int x)
        {
            if (x == 0) return 0;

            int sign = x < 0 ? -1 : 1;

            char[] array = x.ToString().TrimStart('-').ToCharArray();
            Array.Reverse(array);

            try
            {
                return Convert.ToInt32(new string(array)) * sign;
            }
            catch (OverflowException ex)
            {
                return 0;
            }
        }

    }
}