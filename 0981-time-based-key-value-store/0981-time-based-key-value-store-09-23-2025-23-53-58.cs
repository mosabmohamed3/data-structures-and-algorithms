public class TimeMap {
    private Dictionary<string, List<(int timestamp, string value)>> store;

    public TimeMap() 
    {
        store = new Dictionary<string, List<(int, string)>>();
    }
    
    public void Set(string key, string value, int timestamp) 
    {
        if (!store.ContainsKey(key))
            store[key] = new List<(int, string)>();

        store[key].Add((timestamp, value));
    }
    
    public string Get(string key, int timestamp) 
    {
        if (!store.ContainsKey(key))
            return "";

        var arr = store[key];
        int left = 0, right = arr.Count - 1;
        string res = "";

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid].timestamp <= timestamp)
            {
                res = arr[mid].value;
                left = mid + 1;  // try to find a later valid timestamp
            }
            else
                right = mid - 1;
        }
        return res;
    }
}

/**
 * Your TimeMap object will be instantiated and called as such:
 * TimeMap obj = new TimeMap();
 * obj.Set(key,value,timestamp);
 * string param_2 = obj.Get(key,timestamp);
 */