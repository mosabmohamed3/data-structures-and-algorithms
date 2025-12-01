public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var l = 0;
        var r = numbers.Length - 1;

        while(l<r)
        {
            var res = numbers[r] + numbers[l];
            
            if(res == target)
                return new int[] {l + 1, r + 1};
            
            if(res > target)
                r--;
            
            if(res < target)
                l++;
        }

        return default;
    }
}