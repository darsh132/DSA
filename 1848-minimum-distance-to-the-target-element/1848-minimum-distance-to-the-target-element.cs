public class Solution {
    public int GetMinDistance(int[] nums, int target, int start) {
        int minDistance = int.MaxValue;

        for(int i = 0; i < nums.Length; i++) {
            if(nums[i] == target) {
                minDistance = Math.Min(minDistance, Math.Abs(i - start));
                if(minDistance == 0) {
                    return 0;
                }
            }
        }

        return minDistance;
    }
}