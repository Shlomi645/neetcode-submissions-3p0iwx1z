public class Solution {
    public int SingleNumber(int[] nums) {
        int res = 0;
        foreach (int i in nums){
            res = res ^ i;
        }
        return res;
    }
}
