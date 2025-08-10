public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
    var result = new List<IList<int>>();
    var seenTriplets = new HashSet<string>();

    for (int i = 0; i < nums.Length; i++) {
        var seen = new HashSet<int>();
        for (int j = i + 1; j < nums.Length; j++) {
            int needed = -nums[i] - nums[j];
            if (seen.Contains(needed)) {
                var triplet = new List<int> { nums[i], nums[j], needed };
                triplet.Sort(); // sort the triplet itself for duplicate check

                string key = $"{triplet[0]},{triplet[1]},{triplet[2]}";
                if (!seenTriplets.Contains(key)) {
                    seenTriplets.Add(key);
                    result.Add(triplet);
                }
            }
            seen.Add(nums[j]);
        }
    }

    return result;
    }
}