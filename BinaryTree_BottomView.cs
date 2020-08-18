//1st approach: using pre order traversal

class Node
    {
        public int data;
        public int hor_dist;
        public Node left;
        public Node right;

        public Node(int data)
        {
            this.data = data;
            this.left = this.right = null;
        }
        
    }
    
//In this approach, we travertse the tree in pre order traversal and pass a nodes horizontal distance on every recursive call. 
//we also keep a BvMap which contains the final answer. It has a hd as key and node as value.
//Now while traversing, we see if BV map already contains an hd. In that case we just update the node value with current node value, else we add that hd as key and 
//current node as value. Then we recue for node.left a nd node.right. As BvMap is a sorted dictionary, we will have the final answer in correct order.
    public static void BottomViewOfBinaryTree_PreOrderTraversal(Node root)
        {
            setHDForBottomView(root, 0);
        }

        public static SortedDictionary<int, Node> BVMap = new SortedDictionary<int, Node>();
        public static void setHDForBottomView(Node node, int hd)
        {
            if (!BVMap.ContainsKey(hd))
            {
                BVMap.Add(hd, node);
            }
            else
            {
                BVMap[hd] = node;
            }
            if (node.left != null)
            {
                setHDForBottomView(node.left, hd - 1);
            }
            if (node.right != null)
            {
                setHDForBottomView(node.right, hd + 1);
            }
        }
        
    //2nd approach: LevelOrderTraversal
    //here also we maintaina  map of horizontal distances. But we store the HD of each node as a property. 
    
    public static void HDUsingLevelOrderTraversal(Node root)
        {
            Queue<Node> queue = new Queue<Node>();
            SortedDictionary<int, Node> BVMap = new SortedDictionary<int, Node>();
            root.hor_dist = 0;
            queue.Enqueue(root);
            
            while (queue.Count != 0)
            {
                Node n = queue.Dequeue();
              
                if (!BVMap.ContainsKey(n.hor_dist))
                {
                    BVMap.Add(n.hor_dist, n);
                }
                else
                {
                    BVMap[n.hor_dist] = n;
                }
                if (n.left != null)
                {
                    n.left.hor_dist = n.hor_dist - 1;                   
                    queue.Enqueue(n.left);
                }
                if (n.right != null)
                {
                    queue.Enqueue(n.right);
                }
            }
        }
