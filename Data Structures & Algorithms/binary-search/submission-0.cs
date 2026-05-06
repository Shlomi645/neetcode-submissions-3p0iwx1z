public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;
        int res = 0;
        while (left <= right){
            int mid  = left + (right - left) /2;
            if (target == nums[mid]){
                res = mid;
                return res;
            }
            if (target > nums[mid]){
                left = mid + 1;
            }
            if (target < nums[mid]){
                right = mid - 1;
            }
        }
        return -1;
    }
}
