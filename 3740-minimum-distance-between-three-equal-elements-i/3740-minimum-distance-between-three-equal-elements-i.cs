public class Solution {
    public int MinimumDistance(int[] nums) {
        Dictionary<int, List<int>> indices = new();

        for(int i = 0; i < nums.Length; i++) {
            if(!indices.ContainsKey(nums[i])) {
                indices[nums[i]] = new List<int>();
            }
            indices[nums[i]].Add(i);
        }

        int minDistance = int.MaxValue;

        foreach(var list in indices.Values) {
            for(int i = 0; i + 2 < list.Count; i++) {
                int dist = 2 * (list[i + 2] - list[i]);
                minDistance = Math.Min(minDistance, dist);
            }
        }

        return minDistance == int.MaxValue ? -1 : minDistance;
    }
}