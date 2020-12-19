/*Approach 1: using inorder traversal, we keep track of the previously visited node data in every recurssion step. Compare the current node data with that data.
if the current node data is smaller than prev, the BST property is failed and so return false.
Also, for a tree, if any of the left or right subtree is not a BST, that tree is not a BST*/
public class Program
{
  private int prev = min_int;
  public static void main()
  {
  
  }
  
  public static bool isBST(Node root)
  {
    if(root==null)
      return true;
     
     if(!isBST(root.left))
      return false;
     
     if(root.data<prev)
        return false
     
     prev=root.data;
     
     if(!isBST(root.right))
      return false;
      
    return true;
  }
}

