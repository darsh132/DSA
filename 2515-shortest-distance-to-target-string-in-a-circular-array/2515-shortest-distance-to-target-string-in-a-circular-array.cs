public class Solution {
    public int ClosestTarget(string[] words, string target, int startIndex) {
        int n = words.Length;
        int minDistance = int.MaxValue;

        for(int i = 0; i < n; i++) {
            if(words[i] == target) {
                int linearDiff = Math.Abs(i - startIndex);
                int circularDist = Math.Min(linearDiff, n - linearDiff);
                minDistance = Math.Min(minDistance, circularDist);
            }
        }

        return minDistance == int.MaxValue ? -1 : minDistance;
    }
}