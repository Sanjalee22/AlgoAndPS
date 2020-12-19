public class Solution {
    public IList<int> RightSideView(TreeNode root) {
        
        IList<int> list=new List<int>();
        if(root!=null)
            RightView(root, list);
        return list;
        
    }
     
    public void RightView(TreeNode root)
    {
        //We will use the same approach as used in left view of binary tree.
        
        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);
        
        int n = queue.Count;
        while(queue.Count>0)
        {
            
            for(int i = 1; i<=n; ++i)
            {
                Node d = queue.Dequeue();
                
                if(i==n) //means the node d is the last node in this level
                {
                    Console.WriteLine(d.data);
                }
                
                if(d.left!=null)
                    queue.Add(d.left);
                
                if(d.right!=null)
                    queue.Add(d.right);
            }
        }
            
    }
}
