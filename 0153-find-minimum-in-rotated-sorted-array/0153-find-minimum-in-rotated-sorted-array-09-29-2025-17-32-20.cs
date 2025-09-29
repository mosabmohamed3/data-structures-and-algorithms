public class Solution {
    public int FindMin(int[] nums) {
        int l = 0, r = nums.Length - 1;
        int res = nums[0];

        while (l <= r) {
            if (nums[l] < nums[r]) {
                res = Math.Min(res, nums[l]);
                break;
            }

            int m = l + (r - l) / 2;
            res = Math.Min(res, nums[m]);

            if (nums[m] >= nums[l]) {
                l = m + 1;
            } else {
                r = m - 1;
            }
        }

        return res;
    }
}
// public class Solution {
//     public int FindMin(int[] nums) {
//         int left = 0, right = nums.Length - 1, res = nums[0];

//         while(left <= right)
//         {
//             if (nums[right] > nums[left])
//             {
//                 res = Math.Min(res, nums[left]);
//                 break;
//             }

//             int mid = left + (right - left) / 2;
            
//             res = Math.Min(res, nums[mid]);

//             if (nums[mid] > nums[left])
//                 left = mid + 1;
//             else
//                 right = mid - 1; 
//         }
//         return res;
//     }
// }
