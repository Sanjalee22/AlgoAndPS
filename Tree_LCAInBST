public void BST_LCA(Node n1, Node n2, Node root)
        {
            while(root!=null)
            {
                if (root.data > n1.data && root.data > n2.data)
                {
                    root = root.left;
                }

                else if (root.data < n1.data && root.data < n2.data)
                {
                    root = root.right;
                }
                else
                    break;
            }

            Console.WriteLine(root.data);
        }
