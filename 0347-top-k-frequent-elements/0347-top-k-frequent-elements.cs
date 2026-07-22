public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // Step 1: Count the frequency of each element 
        Dictionary<int, int> counts = new Dictionary<int, int>();
        foreach(int num in nums) {
            if(!counts.ContainsKey(num)) {
                counts[num] = 0;
            }
            counts[num]++;
        }

        // Step 2: Create buckets where index = frequency
        List<int>[] buckets = new List<int>[nums.Length + 1];
        foreach(var pair in counts) {
            int frequency = pair.Value;
            if(buckets[frequency] == null) {
                buckets[frequency] = new List<int>();
            }
            buckets[frequency].Add(pair.Key);
        }

        // Step 3: Populate the result array from the highest frequency buckets dowwn
        int[] result = new int[k];
        int index = 0;

        for(int i = buckets.Length - 1; i >= 0 && index < k; i--) {
            if(buckets[i] != null) {
                foreach(int num in buckets[i]) {
                    result[index++] = num;
                    if(index == k) {
                        break;
                    }
                }
            }
        }

        return result;
    }
}