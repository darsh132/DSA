public class Solution {
    public IList<IList<int>> PermuteUnique(int[] nums) {
        var result = new List<IList<int>>();
        Array.Sort(nums);

        bool[] used = new bool[nums.Length];
        var current = new List<int>();

        Backtrack(nums, used, current, result);
        return result;
    }

    private void Backtrack(int[] nums, bool[] used, List<int> current, IList<IList<int>> result) {
        if(current.Count == nums.Length) {
            result.Add(new List<int>(current));
            return;
        }

        for(int i = 0; i < nums.Length; i++) {
            // Skip already chosen indices
            if(used[i]) continue;

            // Skip duplicates: only use nums[i] if nums[i - 1] is already active in current branch
            if(i > 0 && nums[i] == nums[i - 1] && !used[i - 1]) {
                continue;
            }

            used[i] = true;
            current.Add(nums[i]);

            Backtrack(nums, used, current, result);

            // Backtrack
            current.RemoveAt(current.Count - 1);
            used[i] = false;
        }
    }
}