public class Solution {
    public int[] ArrayRankTransform(int[] arr) {
        // Clone the original array and sort it
        int[] sortedArr =  (int[])arr.Clone();
        Array.Sort(sortedArr);

        // Map to store the rank of each unique element
        Dictionary<int, int> ranks = new Dictionary<int, int>();
        int rank = 1;

        foreach(int num in sortedArr) {
            if(!ranks.ContainsKey(num)) {
                ranks[num] = rank;
                rank++;
            }
        }

        // Build the result array based on the original positions
        int[] result = new int[arr.Length];
        for(int i = 0; i < arr.Length; i++) {
            result[i] = ranks[arr[i]];
        }

        return result;
    }
}