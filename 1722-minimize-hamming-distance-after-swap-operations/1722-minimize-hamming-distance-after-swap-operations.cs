public class Solution {
    public int MinimumHammingDistance(int[] source, int[] target, int[][] allowedSwaps) {
        int n = source.Length;
        int[] parent = new int[n];
        for(int i = 0; i < n; i ++) {
            parent[i] = i;
        }

        int Find(int x) {
            if(parent[x] != x) {
                parent[x] = Find(parent[x]);
            }
            return parent[x];
        }

        void Union(int a, int b) {
            int rootA = Find(a);
            int rootB = Find(b);
            if(rootA != rootB) {
                parent[rootA] = rootB;
            }
        }

        // Connect all indices that can be swapped directly or indirectly
        foreach(var swap in allowedSwaps) {
            Union(swap[0], swap[1]);
        }

        // Group indices by their connected component root
        var components = new Dictionary<int, List<int>>();
        for(int i = 0; i < n; i++) {
            int root = Find(i);
            if(!components.TryGetValue(root, out var list)) {
                list = new List<int>();
                components[root] = list;
            }
            list.Add(i);
        }

        int hammingDistance = 0;

        // For each connected component, find elements in source that match
        foreach(var group in components.Values) {
            var countMap = new Dictionary<int, int>();

            // Count element frequencies available in this component from source
            foreach(int idx in group) {
                int val = source[idx];
                countMap.TryGetValue(val, out int count);
                countMap[val] = count + 1;
            }

            // Match against required elements in target
            foreach(int idx in group) {
                int val = target[idx];
                if(countMap.TryGetValue(val, out int count) && count > 0) {
                    countMap[val] = count - 1;
                } else {
                    // Cannot satisfy this position's target element using elements from this component
                    hammingDistance++;
                }
            }
        }
        return hammingDistance;
    }
}