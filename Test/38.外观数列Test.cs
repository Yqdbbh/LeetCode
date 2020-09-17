using Xunit;
using System;
using LeetCode;

namespace LeetCodeTest{
    public class Test_38_wgsl{
        
        [Fact]
        public void FirstIs1()
        {
        //Given
            Solution_38 solution=new Solution_38();
           
        //When
            var str=solution.CountAndSay(1);
        //Then
            Assert.Equal("1",str);
        }

        [Fact]
        public void SecondIs11()
        {
        //Given
            Solution_38 solution=new Solution_38();
           
        //When
            var str=solution.CountAndSay(2);
        //Then
            Assert.Equal("11",str);
        }
        [Fact]
        public void ThirdIs21()
        {
        //Given
            Solution_38 solution=new Solution_38();
           
        //When
            var str=solution.CountAndSay(3);
        //Then
            Assert.Equal("21",str);
        }
    }
}