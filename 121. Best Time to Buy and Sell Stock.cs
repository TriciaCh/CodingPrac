using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _121.Best_Time_to_Buy_and_Sell_Stock
{
    class _121BestTimeToBuyAndSellStock
    {
        // Say you have an array for which the ith element is the price of a given stock on day i.
        //If you were only permitted to complete at most one transaction(i.e., buy one and sell one share of the stock), design an algorithm to find the maximum profit.
        //Note that you cannot sell a stock before you buy one.

        public int MaxProfit(int[] prices)
        {
            

            int len = prices.Length;
            int[] dp = new int[len];

            if(len == 0 || len == 1)
            {
                return 0;
            }

            else
            {
                int min = Math.Min(prices[0], prices[1]);
                dp[0] = 0;
                dp[1] = prices[1] - prices[0];

                for (int i = 2; i < len; i++)
                {
                    dp[i] = prices[i] - min;
                    if(prices[i] < min)
                    {
                        min = prices[i];
                    }
                }

                var maxProfit = -1;

                if(dp[1] <= 0)
                {
                    maxProfit = 0;
                }

                else
                {
                    maxProfit = dp[1];
                }

                for (int j = 0; j < len; j++)
                {
                    if(dp[j] > maxProfit)
                    {
                        maxProfit = dp[j];
                    }
                }

                return maxProfit;
            }

        }

        // fast solution
        public int MaxProfitFast(int[] prices)
        {
            if (prices.Length == 0)
                return 0;

            int max = 0;
            int buy = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > buy)
                {
                    if (prices[i] - buy > max)
                    {
                        max = prices[i] - buy;
                    }
                }
                else
                {
                    buy = prices[i];
                }
            }

            return max;

        }


        static void Main(string[] args)
        {
            _121BestTimeToBuyAndSellStock p = new _121BestTimeToBuyAndSellStock();
            int[] arr = new int[] { 4,1,9,3,4,5,1,7,3,};
            var re = p.MaxProfit(arr);
            Console.WriteLine(re);
            Console.Read();

        }
    }
}
