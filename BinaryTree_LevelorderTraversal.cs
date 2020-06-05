public static void LevelOrderTraversal(Node root)
        {
            
            Queue<Node> queue = new Queue<Node>();

            queue.Enqueue(root);
            while(queue.Count!=0)
            {
                Node n = queue.Dequeue();
                Console.WriteLine(n.data);
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
