public class Solution {
    public IList<int> FindMissingElements(int[] nums) {
        HashSet<int> present = new HashSet<int>(nums);
        int min = nums[0];
        int max = nums[0];

        foreach(int num in nums) {
            if(num < min) min = num;
            if(num > max) max = num;
        }

        List<int> missing = new List<int>();
        for(int i = min + 1; i < max; i++) {
            if(!present.Contains(i)) {
                missing.Add(i);
            }
        }

        return missing;
    }
}