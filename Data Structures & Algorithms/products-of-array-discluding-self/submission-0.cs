public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] res = new int[nums.Length];
        int[] leftProduct = new int[nums.Length];
        int[] rightProduct = new int[nums.Length];
        leftProduct[0] = 1;
        rightProduct[nums.Length - 1] = 1;

        for (int i = 1; i < nums.Length; i++) {
            leftProduct[i] = leftProduct[i - 1] * nums[i - 1];
        }

        for (int i = nums.Length - 2; i >= 0; i--) {
            rightProduct[i] = rightProduct[i + 1] * nums[i + 1];
        }

        for (int i = 0; i < nums.Length; i ++){
            res[i] = leftProduct[i] * rightProduct[i];
        }
        return res;

    }
}
