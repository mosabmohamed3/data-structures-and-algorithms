public class Solution {
    public int MaxProfit(int[] prices) {
        var maxSoFar = prices[prices.Length-1];
        var maxP = 0;
        int n = prices.Length;
        
        for (int i = n-1 ; i >= 0; i--){
            maxP = getMax(maxP, maxSoFar - prices[i]);
            maxSoFar = getMax(maxSoFar, prices[i]);
        }
        
        return maxP;
    }
    
    private int getMax(int x, int y){
        if (x > y)
            return x;
        else
            return y;
    }
}