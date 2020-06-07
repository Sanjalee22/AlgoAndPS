    class Node
    {
        public int data;

        public Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }

    }


    class Program
    {

        public static void Main(string[] args)
        {
            int noOfTC = Convert.ToInt32(Console.ReadLine());
             
            for (int t = 0; t < noOfTC; ++t)
            {
                //int num = Convert.ToInt32(Console.ReadLine());
                //string[] s1 = Console.ReadLine().Split(' ');
                //int[] arr = Array.ConvertAll(s1, int.Parse);
                //string str = Console.ReadLine();
                Node root = new Node(1);
                Node last = root;
                for(int i=2;i<6;++i)
                {
                    last.next = new Node(i);
                    last = last.next;
                }

                Node res=reverseList(root,3);
                Node n = res;
                while (n != null)
                {
                    Console.WriteLine(n.data);
                    n = n.next;
                }

            }
            Console.ReadLine();
        }
        public static Node reverseList(Node head, int k)
        {
            // add code here
            Node curr = head;
            Node nextnode = null, tmp = null;
            int count = 1;
            while (curr != null && count<=k)
            {
                nextnode = curr.next;     // Take the head next as nextnode
                curr.next = tmp;          // Make the head next as tmp node
                tmp = curr;               // Update tmp node to store the head node
                curr = nextnode;          // Make head next move to the next node
                count++;
            }

            if (curr != null)
                head.next = reverseList(curr, k);
          
            return tmp;
        }
    }
