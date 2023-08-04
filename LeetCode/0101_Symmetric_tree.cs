// Solution using Recursion

public static bool IsSymmetric(TreeNode root) {
    bool sym = false;
    if (root == null) sym = true;
    else sym = IsSymmetric2(root.left, root.right);

    return sym;
}
public static bool IsSymmetric2(TreeNode firstNode, TreeNode secondNode){
    bool sym = false;
    if (firstNode == null && secondNode == null) sym = true;
    else if (firstNode == null || secondNode == null) sym = false;
    else if (firstNode.val != secondNode.val) sym = false;
    else sym = IsSymmetric2(firstNode.left, secondNode.right) 
                && IsSymmetric2(firstNode.right, secondNode.left);
    return sym;
}
