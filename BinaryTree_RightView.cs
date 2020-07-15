public class Solution {
    public IList<int> RightSideView(TreeNode root) {
        
        IList<int> list=new List<int>();
        if(root!=null)
            RightView(root, list);
        return list;
        
    }
     
    public void RightView(TreeNode root, IList<int> list)
    {
            TreeNode dummy = new TreeNode(-1);
            Queue<TreeNode> queue = new Queue<TreeNode>();
            int level = 0;
            queue.Enqueue(root);
            queue.Enqueue(dummy);           
            
            
            while (queue.Count != 0)
            {
                TreeNode n = queue.Dequeue();
                if(queue.Count!=0 && queue.Peek()==dummy) //if after dequeue, the peek element is dummy, that meant the dequeued element is the last in that level. Put it in list.
                    list.Add(n.val);
                if(n==dummy) //change of level
                {
                    if (queue.Count == 0)
                        break;
                    level++;                                      
                    queue.Enqueue(dummy);
                    continue;
                }
                
                if (n.left != null)
                {
                    queue.Enqueue(n.left);
                }
                if (n.right != null)
                {
                    queue.Enqueue(n.right);
                }
            }
    }
}
