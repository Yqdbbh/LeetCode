using System;
using Xunit;
using LeetCode;

namespace LeetCodeTest{
    public class PowerOfTwoTest{
        
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(268435456)]
        public void IsPowerOfTwo(int n)
        {
        //Given
            Solution_231 sln=new Solution_231();

        //When
            bool res= sln.IsPowerOfTwo(n);
        //Then
            Assert.True(res);
        }

        [Theory]
        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        [InlineData(0)]
        [InlineData(1083179008)]
        [InlineData(6)]
        [InlineData(3)]
        public void NotPowerOfTwo(int n){
            Solution_231 sln=new Solution_231();
            bool res=sln.IsPowerOfTwo(n);
            Assert.False(res);
        }

    }
}