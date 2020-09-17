using System;
using Xunit;
using LeetCode;
namespace LeetCodeTest
{
    public class PlusOneTest
    {
        [Fact]
        public void NinePlusOneIsTen()
        {
            Solution_66 solution=new Solution_66();
            int[] arr= solution.PlusOne(new int[1]{9});
            Assert.Equal(2,arr.Length);
            Assert.Equal(1,arr[0]);
            Assert.Equal(0,arr[1]);
        }

    }
}
