public class Solution {
    public int MaxProfit(int[] prices) {
        var l = 0;
        var r = 1;
        var maxP = 0;
        
        while(r < prices.Length)
        {
            var p = prices[r] - prices[l];
            
            if(prices[l] < prices[r] && p > maxP)
            {
                maxP = p;
            }
            else if(prices[l] > prices[r] || prices[l] == prices[r])
            {
                l = r;
            } 
            
            r++;
        }
        
        return maxP;
    }
}