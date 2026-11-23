public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> seen = new Dictionary<int, int>(nums.Length);

        for(int i = 0;i < nums.Length; i++) {
            int complement = target - nums[i];

            if(seen.TryGetValue(complement, out int complementIndex)) {
                return new int[] {complementIndex, i};
            }

            seen[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}