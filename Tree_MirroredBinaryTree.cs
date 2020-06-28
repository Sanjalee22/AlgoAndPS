//Check if a BT is mirror of itself
public class Solution {
    public bool IsSymmetric(TreeNode root) {
        if(root==null)
        return true;
        return Mirror(root.left, root.right);
    }
    
    public bool Mirror(TreeNode node1, TreeNode node2)
    {
       if(node1==null && node2==null)
            return true;
        
        if(node1==null || node2==null)
            return false;
        
        if((node1.val==node2.val) && Mirror(node1.left, node2.right) 
           && Mirror(node1.right, node2.left))
            return true;
        return false;
    }
    
}
