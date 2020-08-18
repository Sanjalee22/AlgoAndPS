// C# implementation of an O(n) approach of 
// level order traversal in spiral form 
using System; 
using System.Collections.Generic; 

// A Binary Tree node 
public class Node { 
	public int data; 
	public Node left, right; 

	public Node(int item) 
	{ 
		data = item; 
		left = right = null; 
	} 
} 

public class BinaryTree { 
	public static Node root; 

	public virtual void printSpiral(Node node) 
	{ 
		if (node == null) { 
			return; // NULL check 
		} 

		// Create two stacks to store alternate levels 
		Stack<Node> s1 = new Stack<Node>(); // For levels to be printed 
		// from right to left 
		Stack<Node> s2 = new Stack<Node>(); // For levels to be printed 
		// from left to right 

		// Push first level to first stack 's1' 
		s1.Push(node); 

		// Keep printing while any of the 
		// stacks has some nodes 
		while (s1.Count > 0 || s2.Count > 0) { 
			// Print nodes of current level from 
			// s1 and push nodes of next level to s2 
			while (s1.Count > 0) { 
				Node temp = s1.Peek(); 
				s1.Pop(); 
				Console.Write(temp.data + " "); 

				// Note that is right is pushed before left 
				if (temp.right != null) { 
					s2.Push(temp.right); 
				} 

				if (temp.left != null) { 
					s2.Push(temp.left); 
				} 
			} 

			// Print nodes of current level from s2 
			// and push nodes of next level to s1 
			while (s2.Count > 0) { 
				Node temp = s2.Peek(); 
				s2.Pop(); 
				Console.Write(temp.data + " "); 

				// Note that is left is pushed before right 
				if (temp.left != null) { 
					s1.Push(temp.left); 
				} 
				if (temp.right != null) { 
					s1.Push(temp.right); 
				} 
			} 
		} 
	} 

	// Driver Code 
	public static void Main(string[] args) 
	{ 
		BinaryTree tree = new BinaryTree(); 
		BinaryTree.root = new Node(1); 
		BinaryTree.root.left = new Node(2); 
		BinaryTree.root.right = new Node(3); 
		BinaryTree.root.left.left = new Node(7); 
		BinaryTree.root.left.right = new Node(6); 
		BinaryTree.root.right.left = new Node(5); 
		BinaryTree.root.right.right = new Node(4); 
		Console.WriteLine("Spiral Order traversal of Binary Tree is "); 
		tree.printSpiral(root); 
	} 
} 

// This code is contributed by Shrikant13 
