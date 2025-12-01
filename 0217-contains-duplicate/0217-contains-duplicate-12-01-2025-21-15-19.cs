public class Solution {
    public bool ContainsDuplicate(int[] nums) {
            var hashSet = new HashSet<int>();
            for (var i = 0; i < nums.Length; i++)
            {
                var numOFList = nums[i];
                if(!hashSet.Contains(numOFList))
                    hashSet.Add(numOFList);
                else
                    return true;
            }

            return false;
    }
}