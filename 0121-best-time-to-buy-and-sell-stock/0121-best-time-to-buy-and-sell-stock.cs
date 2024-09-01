public class Solution {
    public int MaxProfit(int[] prices) {
        var maxSoFar = prices[prices.Length-1];
        var maxP = 0;
        int n = prices.Length;
        
        for (int i = n-1 ; i >= 0; i--){
            maxP = Math.Max(maxP, maxSoFar - prices[i]);
            maxSoFar = Math.Max(maxSoFar, prices[i]);
        }
        
        return maxP;
    }
}