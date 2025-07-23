public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var result = new List<int>();

        for(var i = 0; i < nums.Length; i++)
        {
            var temp = 1;
            for(var l = 0; l < nums.Length; l++)
            {
                if(i != l)
                {
                    temp = temp * nums[l];
                }
            }

            result.Add(temp);
        }

        return result.ToArray();
    }
}