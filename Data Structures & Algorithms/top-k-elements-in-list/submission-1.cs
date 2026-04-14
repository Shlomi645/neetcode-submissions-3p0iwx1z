public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> counts = new Dictionary<int, int>();
        foreach (int n in nums){
            if (!counts.ContainsKey(n)){
                counts[n] = 1;
            }

            else {
                counts[n]++;
            }
        }

        return counts.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToArray();
    }
}
