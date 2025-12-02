public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0, r = nums.Length - 1;
        while (l <= r)
        {
            var mid = l + (r - l) / 2;
            if(target == nums[mid])
                return mid;
            else if (target > nums[mid])
                l++;
            else
                r--;
        }

        return -1;
    }
}