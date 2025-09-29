public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1; //min hours
        int right = piles.Max(); //max hours

        while(left < right)
        {
            int mid = left + (right - left) / 2;

            if(CanbeValid(piles, h, mid))
                right = mid;
            else
                left = mid + 1;
        }
        return right;
    }

    public bool CanbeValid(int[] p, int h, int k)
    {
        int hours = 0;
        foreach(int pile in p)
        {
            hours += (pile + k - 1) / k;
            if(hours > h)
                return false;
        }
        return hours <= h;
    }
}
