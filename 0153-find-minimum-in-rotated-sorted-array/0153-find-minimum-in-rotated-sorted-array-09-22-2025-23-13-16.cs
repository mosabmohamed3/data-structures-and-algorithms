public class Solution {
    public int FindMin(int[] nums) {
        int min = nums[0];
        foreach(int num in nums)
        {
            if(num < min)
                min = num;
        }
        return min;
    }
}