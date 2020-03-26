// 122. Best Time to Buy and Sell Stock II  Easy
// Say you have an array for which the ith element is the price of a given stock on day i.

// Design an algorithm to find the maximum profit. You may complete as many transactions as you like (i.e., buy one and sell one share of the stock multiple times).

// Note: You may not engage in multiple transactions at the same time (i.e., you must sell the stock before you buy again).

// Example 1:

// Input: [7,1,5,3,6,4]
// Output: 7
// Explanation: Buy on day 2 (price = 1) and sell on day 3 (price = 5), profit = 5-1 = 4.
//              Then buy on day 4 (price = 3) and sell on day 5 (price = 6), profit = 6-3 = 3.
// Example 2:

// Input: [1,2,3,4,5]
// Output: 4
// Explanation: Buy on day 1 (price = 1) and sell on day 5 (price = 5), profit = 5-1 = 4.
//              Note that you cannot buy on day 1, buy on day 2 and sell them later, as you are
//              engaging multiple transactions at the same time. You must sell before buying again.
// Example 3:

// Input: [7,6,4,3,1]
// Output: 0
// Explanation: In this case, no transaction is done, i.e. max profit = 0.
namespace LeetCode{
    /// <summary>
    /// 最大收益升级版，允许买卖多次
    /// </summary>
    public partial class BastTimeToBuyAndSellStock{
        /// <summary>
        /// 分析：
        /// 分析不出来，看讨论区的答案也看不懂，还是度娘好使，看明白了
        /// https://blog.csdn.net/feliciafay/article/details/18579661
        /// 从全局出发，求所有收益的单调增区间
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfitMultiple(int[] prices) {
            if(prices.Length<2) return 0;
            int res = 0;
            for (int i = 1; i < prices.Length;i++){
                if(prices[i]>prices[i-1])
                    res += (prices[i] - prices[i - 1]);
            }
            return res;
        }

        #region 思维里的墙
        /// in\out  7  1  5  3  6  4    
        ///         
        ///   7    0   -6 -2 -4 -1 -3
        ///   1       0  [4]  2  5  3   --4 (1,2)  
        ///   5           0  -2  1 -1
        ///   3              0  [3] 1   --3 (3,4)
        ///   6                 0  -2
        ///   4                     0
        /// 
        ///   \  1 2 3 4 5 6
        /// 
        ///   1    1 2 3 4 5  -- 2  (0,2)  
        ///   2      1 2 3 4
        ///   3        1 2 3     -- 2  (2,4)
        ///   4          1 2
        ///   5            1
        ///   6
        ///   求子矩阵的和的最大值？？？递归求解？？
        /// 
        #endregion
    }
}