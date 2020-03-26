// 121. Best Time to Buy and Sell Stock     Easy
// Say you have an array for which the ith element is the price of a given stock on day i.

// If you were only permitted to complete at most one transaction (i.e., buy one and sell one share of the stock), design an algorithm to find the maximum profit.

// Note that you cannot sell a stock before you buy one.

// Example 1:

// Input: [7,1,5,3,6,4]
// Output: 5
// Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
//              Not 7-1 = 6, as selling price needs to be larger than buying price.
// Example 2:

// Input: [7,6,4,3,1]
// Output: 0
// Explanation: In this case, no transaction is done, i.e. max profit = 0.

using System;

namespace LeetCode{
    /// <summary>
    /// 求股票最大收益，要求 卖出价格 > 买入价格,卖出时间 > 买入时间
    /// </summary>
    public partial class BastTimeToBuyAndSellStock{
        public int MaxProfit(int[] prices) {
            // in\out  7  1  5  3  6  4 
            //   7       -6 -2 -4 -1 -3
            //   1           4  2  5  3
            //   5             -2  1 -1
            //   3                 3  1
            //   6                   -2
            //   4
            if(prices==null||prices.Length==0) return 0;
            var maxProfit = 0;
            for (var i = 1; i < prices.Length;i++){ // 卖出
                //var tmp = 0;
                for (var j = 0; j < i;j++){ // 买入
                    var tmp = prices[i] - prices[j];
                    // if(tmp<=0)
                    //     continue;
                    // if(tmp>maxProfit)
                    //     maxProfit = tmp;
                    maxProfit = Math.Max(tmp, maxProfit);
                }
            }
            return maxProfit;
        }
    }
}