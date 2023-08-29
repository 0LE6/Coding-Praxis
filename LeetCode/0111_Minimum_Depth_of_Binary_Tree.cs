public static int MinDepth(TreeNode root) {
        
        int minHeight;
        if (root == null) return 0;
        if (root.left == null) minHeight = MinDepth(root.right) + 1;
        else if (root.right == null) minHeight = MinDepth(root.left) + 1;
        else {
            int leftHeight = MinDepth(root.left);
            int rightHeight = MinDepth(root.right);
            minHeight =  Math.Min(leftHeight, rightHeight) + 1;
        }
        return minHeight;
    }
