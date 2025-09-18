public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
        int[] result = new int[n];

        for(int l = 0; l < n; l++)
        {
            int distance = 1;
            int r = l + 1;

            while(r < n)
            {
                if(temperatures[r] > temperatures[l])
                {
                    result[l] = distance;
                    break;
                }
                else
                {
                    distance++;
                    r++;
                }
            }
        }

        return result;
        // int n = temperatures.Length;
        // int[] res = new int[n];
        // Stack<int> stack = new Stack<int>(); // stores indices

        // for (int i = 0; i < n; i++) {
        //     while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()]) {
        //         int prevIndex = stack.Pop();
        //         res[prevIndex] = i - prevIndex;
        //     }
        //     stack.Push(i);
        // }

        // return res;
    }
}
