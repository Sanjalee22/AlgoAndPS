public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
   
        return PreOrder(p,q);
    }
    
    public bool PreOrder(TreeNode node1, TreeNode node2)
    {
        if(node1==null && node2==null)
            return true;
        if(node1==null || node2==null)
            return false;
        if((node1.val != node2.val))
            return false;
        if(!PreOrder(node1.left, node2.left))
            return false;
        if(!PreOrder(node1.right, node2.right))
            return false;
        return true;
    }
}
