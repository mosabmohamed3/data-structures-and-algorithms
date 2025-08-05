public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        // var dic = new Dictionary<int,int>();
        // for(var i = 0; i < numbers.Length; i++)
        // {
        //     var num = target - numbers[i];

        //     if(dic.ContainsKey(num))
        //         return new int[] {dic[num], i+1};

        //     if(!dic.ContainsKey(numbers[i]))
        //         dic[numbers[i]] = i + 1;
        // }

        // return default;

        var l = 0;
        var r = numbers.Length - 1;

        while(l<r)
        {
            var sum = numbers[l] + numbers[r];

            if (sum == target)
                return new int[] {l + 1, r + 1};
            
            if (sum > target)
                r--;
            else
                l++;
        }

        return default;
    }
}