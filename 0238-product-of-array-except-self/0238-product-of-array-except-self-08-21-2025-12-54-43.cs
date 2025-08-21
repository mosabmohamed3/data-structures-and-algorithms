public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var n = nums.Length;

        var prefix = new int[n];
        var suffix = new int [n];
        var result = new int [n];

        prefix[0]=1;
        suffix[n-1]=1;

        for(var i = 1; i <n; i++)
        {
            prefix[i] = prefix[i-1] * nums[i-1];
        }

        for(var i=n-2; i>=0; i--)
        {
            suffix[i] = suffix[i+1] * nums[i+1];
        }

        for(var i=0; i<n; i++)
        {
            result[i] = suffix[i] * prefix[i];
        }

        return result;
    }
}