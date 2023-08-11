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
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> list = new List<int>();
        InorderTraversalAux(root, list);
        return list;
    }

    private static void InorderTraversalAux(TreeNode node, List<int> list) {
        if (node != null){
            InorderTraversalAux(node.left, list); // from left to right
            list.Add(node.val); // ain't left then Add
            InorderTraversalAux(node.right, list); // process right and start again
        }
    }
}
