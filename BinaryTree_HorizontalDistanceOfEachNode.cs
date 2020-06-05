//print horizontal distance of each node
class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int data)
        {
            this.data = data;
            this.left = this.right = null;
        }
        
    }
public static void HorizontalDistanceOfEachNode(Node root)
        {
            setHD(root, 0);
        }
        public static void setHD(Node node, int hd)
        {
            Console.WriteLine(node.data + "-->" + hd);
            if (node.left != null)
            {
                setHD(node.left, hd - 1);
            }
            if (node.right != null)
            {
                setHD(node.right, hd + 1);
            }
        }
