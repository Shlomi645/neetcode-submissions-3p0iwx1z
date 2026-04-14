public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numSet = new HashSet<int>(nums);
        int longestStreak = 0;

        foreach (int num in nums){
            if (!numSet.Contains(num - 1)) { 
                int currentNum = num;
                int currentStreak = 1;

                while (numSet.Contains(currentNum + 1)) {
                    currentNum += 1;
                    currentStreak += 1;
                }

                if (currentStreak >= longestStreak){
                    longestStreak = currentStreak;
                }
            }
        }

        return longestStreak;
    }
}
