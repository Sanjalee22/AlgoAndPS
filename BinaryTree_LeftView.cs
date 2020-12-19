/* Approach 1: Recurssion
The idea is to do a simple recursive traversal of the binary tree. At every level, print the first node of that level. 
Now how do you know if a level is changed?We pass level as a parameter in the recursive function. We also keep track of max level so far in the code. 
As sson as you encounter a call where the level is greater that the max level so far, you know that that node is teh first node in the next level. So 
print it.
Then you recursively call the left and right child node of that node with level increased by +1 as the child nodes are in next level. */

public class Node
{
  public int data;
  public Node left;
  public Node right;
  
  public Node(int n)
  {
    data = n;
  }
}

public class 
{
  public Node root;
  public static int max_Level = 0;
  
  public static void LeftView(Node node, int node_level)
  {
    if(node == null) // some nodes might not have any child or left or right child.
      {
        return;
      }
      
    //Now see whether the level of current node is greater than max_level. If so, we are at the next level and at the first node of that level because the left most child is 
    //always called first in the recursive call and the variable max_Level is static.
    
    
    if(node_level > max_Level)
    {
      Console.WriteLine(node.data);
      //change the max_Level to current level
      max_Level = node_level;
    }
    
    //So this recurssion is like the entire left side will be explored first for a tree before it goes back to the right child because the
    //call to first left will again call the first left of that child.
    LeftView(node.left, node_level + 1);
    LeftView(node.right, node_level + 1);
 
  }
}

//Time Complexity: Since it explores all the nodes of the tree at least once, its O(n)
//Space complexity: O(n) because of the recursive call stack.
//ex: 1 2 3 _ 5 _ 6
//call will be like LV(1, 1) -> LV(2,2) -> LV(null, 3) -> LV(5, 3) -> LV(null, 4) ->LV(null, 4)->
// LV(3, 2) -> LV(null, 3) -> LV(6, 3) -> LV(null, 4) -> LV(null, 4)

/*Approach 2:
Using Level Oeder Traversal.
We insert teh nodes in queue. And run a loop till queue is not empty.

public class LeftView
{
  
  public static void Print_LeftView(Node root)
  {
    Queue<Node> queue =new Queue<Node>();
    queue.Enqueue(root.data);
    
    while(queue.Count>0)
    {
      int n = queue.Count; // store current count in n here so that we know the number of nodes in each level. Later we keep dequeqing nodes from the current level in the
      //loop that follows. 
      for(int i = 1; i<=n; ++i) this loops through all the nodes in one level at a time because n is that count of nodes.
      {
        Node d = queue.Dequeue(); 
        if(i==1) //for every level, print first node. 
        {
          Console.WriteLine(d.data);
        }

// In following lines, we just enqueue the rest of the nodes because we need those nodes. In case, the first node of this level does not
//have any children, but the second node has children, that child will be shown in the left view. Hence we have to keep all nodes at every level.

        if(d.left!=null)
          queue.Enqueue(d.left); //This will increase the count of queue but we will come out if this for loop when we have gone through all the nodes of current level.

        if(d.right!=null)
          queue.Enqueue(d.right);
      } 
   }
    
  }
}

//Time complexity: O(n)
//Space complexity: O(n)
