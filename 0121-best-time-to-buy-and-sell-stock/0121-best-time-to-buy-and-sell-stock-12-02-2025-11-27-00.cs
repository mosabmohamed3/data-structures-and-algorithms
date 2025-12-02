public class Solution {
    public int MaxProfit(int[] prices) {        
        int l = 0, r = 1, maxProf = 0;

        while(r < prices.Length)
        {
            if(prices[l] < prices[r])
                maxProf = Math.Max(maxProf, prices[r] - prices[l]);
            else
                l = r;
            
            r++;
        }

        return maxProf;
    }
}