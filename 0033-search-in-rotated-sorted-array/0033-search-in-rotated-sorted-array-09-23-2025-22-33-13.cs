public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0;
        int r = nums.Length - 1;
        int res = -1;

        while(l <= r)
        {
            int m = l + (r - l) / 2;
            if(nums[m] == target)
                return m;
            if(nums[r] == target)
                return r;
            if(nums[l] == target)
                return l;

            if(nums[m] > nums[l])
            {
                if(target < nums[m] && target > nums[l])
                    r = m - 1;
                else
                    l = m + 1;
            }
            else
            {
                if(target > nums[m] && target < nums[r])
                    l = m + 1;
                else
                    r = m - 1;
            }
        }

        return res;
    }
}