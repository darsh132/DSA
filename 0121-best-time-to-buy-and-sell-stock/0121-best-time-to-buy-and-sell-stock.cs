public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = int.MaxValue;
        int maxProfit = 0;

        for(int i = 0; i < prices.Length; i++) {
            if(prices[i] < minPrice) {
                // Track the lowest buying price seen so far
                minPrice = prices[i];
            } else {
                // If sold today, check if it yeilds a higher profit
                int currentProfit = prices[i] - minPrice;
                if(currentProfit > maxProfit) {
                    maxProfit = currentProfit;
                }
            }
        }

        return maxProfit;
    }
}