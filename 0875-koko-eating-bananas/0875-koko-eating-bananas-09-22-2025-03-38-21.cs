public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1;
        int right = piles.Max(); // max pile size

        while (left < right) {
            int mid = left + (right - left) / 2;
            if (CanEatAll(piles, h, mid)) {
                right = mid; // try smaller k
            } else {
                left = mid + 1; // need bigger k
            }
        }

        return left;
    }

    private bool CanEatAll(int[] piles, int h, int k) {
        long hours = 0;
        foreach (int pile in piles) {
            hours += (pile + k - 1) / k; // ceil(pile / k)
            if (hours > h) return false;
        }
        return hours <= h;
    }
}
