/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int GoodNodes(TreeNode root) {
        // Start DFS from the root, initializing maxSoFar with the root's value
        return Dfs(root, root.val);
    }

    private int Dfs(TreeNode node, int maxSoFar) {
        if(node == null) {
            return 0;
        }

        int good = 0;

        // If current node's valus is >= maximum value in the path so far, it's goog node
        if(node.val >= maxSoFar) {
            good = 1;
            maxSoFar = node.val; // Update the running maximum for the path
        }

        // Accumulate good nodes from current node, left subtree, and right subtree
        good += Dfs(node.left, maxSoFar);
        good += Dfs(node.right, maxSoFar);

        return good;
    }
}