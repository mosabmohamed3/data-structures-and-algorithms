public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        var set = new HashSet<int>(nums);
        var listOfLen = new List<int>();

        foreach(var num in set)
        {
            if(!set.Contains(num - 1))
            {
                var currentNum = num;
                var length = 1;

                while(set.Contains(currentNum + 1))
                {
                    currentNum++;
                    length++;
                }

                listOfLen.Add(length);
            }
        }
        var longest= 0;
        foreach(var l in listOfLen)
            if(l > longest)
                longest = l;

        return longest;
    }
}
