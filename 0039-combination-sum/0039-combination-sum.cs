public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        var result = new List<IList<int>>();
        Array.Sort(candidates);
        Backtrack(candidates, target, 0, new List<int>(), result);
        return result;
    }

    private void Backtrack(int[] candidates, int remain, int start, List<int> current, IList<IList<int>> result)  {
        if(remain == 0) {
            result.Add(new List<int>(current));
            return;
        }

        for(int i = start; i < candidates.Length; i++) {
            // Prune the branch since candidates is sorted
            if(candidates[i] > remain) {
                break;
            }

            current.Add(candidates[i]);
            // Pass 'i' instead 'i + 1' to allow reusing the same element
            Backtrack(candidates, remain - candidates[i], i, current, result);
            current.RemoveAt(current.Count - 1);
        }

    }
}