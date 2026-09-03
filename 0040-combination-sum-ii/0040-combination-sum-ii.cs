public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        var result = new List<IList<int>>();
        Array.Sort(candidates);
        Backtrack(candidates, target, 0, new List<int>(), result);
        return result;
    }

    private void Backtrack(int[] candidates, int remain, int start, List<int> current, IList<IList<int>> result) {
        if(remain == 0) {
            result.Add(new List<int>(current));
            return;
        }

        for(int i = start; i < candidates.Length; i++) {
            // Prune branches: subsequent numbers will also exceed remain
            if(candidates[i] > remain) {
                break;
            }

            // Skip duplicates at the same tree depth
            if(i > start && candidates[i] == candidates[i - 1]) {
                continue;
            }

            current.Add(candidates[i]);
            // Move to i + 1 since each number can only be used once
            Backtrack(candidates, remain - candidates[i], i + 1, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}