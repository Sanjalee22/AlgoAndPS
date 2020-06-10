//Complete the function to print spiral order traversal of a tree. For below tree, function should print 1, 2, 3, 4, 5, 6, 7.

public class Node { 
    public int data; 
    public Node left, right; 
  
    public Node(int d) 
    { 
        data = d; 
        left = right = null; 
    } 
} 
  
class GFG { 
    public Node root; 
  
    // Function to print the spiral 
    // traversal of tree 
    public virtual void printSpiral(Node node) 
    { 
        int h = height(node); 
        int i; 
  
        /* ltr -> left to right. If this  
        variable is set then the given 
        label is traversed from left to right */
        bool ltr = false; 
        for (i = 1; i <= h; i++) { 
            printGivenLevel(node, i, ltr); 
  
            /*Revert ltr to traverse next  
              level in opposite order*/
            ltr = !ltr; 
        } 
    } 
  
    /* Compute the "height" of a tree -- the 
    number of nodes along the longest path  
    from the root node down to the farthest  
    leaf node.*/
    public virtual int height(Node node) 
    { 
        if (node == null) { 
            return 0; 
        } 
        else { 
  
            /* compute the height of each subtree */
            int lheight = height(node.left); 
            int rheight = height(node.right); 
  
            /* use the larger one */
            if (lheight > rheight) { 
                return (lheight + 1); 
            } 
            else { 
                return (rheight + 1); 
            } 
        } 
    } 
  
    /* Print nodes at a given level */
    public virtual void printGivenLevel(Node node, 
                                        int level, 
                                        bool ltr) 
    { 
        if (node == null) { 
            return; 
        } 
        if (level == 1) { 
            Console.Write(node.data + " "); 
        } 
        else if (level > 1) { 
            if (ltr != false) { 
                printGivenLevel(node.left, level - 1, ltr); 
                printGivenLevel(node.right, level - 1, ltr); 
            } 
            else { 
                printGivenLevel(node.right, level - 1, ltr); 
                printGivenLevel(node.left, level - 1, ltr); 
            } 
        } 
    } 
  
    // Driver Code 
    public static void Main(string[] args) 
    { 
        GFG tree = new GFG(); 
        tree.root = new Node(1); 
        tree.root.left = new Node(2); 
        tree.root.right = new Node(3); 
        tree.root.left.left = new Node(7); 
        tree.root.left.right = new Node(6); 
        tree.root.right.left = new Node(5); 
        tree.root.right.right = new Node(4); 
        Console.WriteLine("Spiral order traversal "
                          + "of Binary Tree is "); 
        tree.printSpiral(tree.root); 
    } 
} 
