public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var dic = new Dictionary<int,int>();
        for(var i = 0; i < numbers.Length; i++)
        {
            var num = target - numbers[i];

            if(dic.ContainsKey(num))
                return new int[] {dic[num], i+1};

            if(!dic.ContainsKey(numbers[i]))
                dic[numbers[i]] = i + 1;
        }

        return default;
    }
}