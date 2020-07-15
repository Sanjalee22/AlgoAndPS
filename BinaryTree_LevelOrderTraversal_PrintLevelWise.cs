public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
         IList<IList<int>> list = new List<IList<int>>();
        if(root!=null)
            LevelOrderTraversal(root, list);
        return list;
        
    }
    
    public void LevelOrderTraversal(TreeNode root, IList<IList<int>> list)
        {
            TreeNode dummy = new TreeNode(-1);
            Queue<TreeNode> queue = new Queue<TreeNode>();
            int level = 0;
            queue.Enqueue(root);
            queue.Enqueue(dummy);           
            list.Add(new List<int>());
            
            while (queue.Count != 0)
            {
                TreeNode n = queue.Dequeue();
                if(n==dummy) //change of level
                {
                    if (queue.Count == 0)
                        break;
                    level++;
                    list.Add( new List<int>());                    
                    queue.Enqueue(dummy);
                    continue;
                }
                list[level].Add(n.val);
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
