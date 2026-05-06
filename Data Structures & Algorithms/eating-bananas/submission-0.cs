public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int right ,left;
        right  = piles.Max();
        left = 1;
        while(left < right){
            int mid = left + (right - left)/2;

            if (CanEatAll(piles,h,mid)){
                right = mid;
            }
            else{
                left = mid +1;
            }
        }
        return left;
    }

    private bool CanEatAll(int[] piles, int h, int k){
        long hours = 0;
        foreach(int pile in piles){
            hours += (pile + k - 1)/k;
            if (hours > h){
                return false;
            }
        }
        return hours <= h;
    }
}
