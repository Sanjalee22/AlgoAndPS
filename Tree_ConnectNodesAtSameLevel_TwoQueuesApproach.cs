 public class Node
    {
        public int data;
        
        public Node left;
        public Node right;
        public Node nextRight;
        public Node(int data)
        {
            this.data = data;
            left = right = nextRight = null;
            
        }

    }


   


    class Program
    {

        public static void Main(string[] args)
        {
           
            int noOfTC = Convert.ToInt32(Console.ReadLine());
             
            for (int t = 0; t < noOfTC; ++t)
            {
                ////int num = Convert.ToInt32(Console.ReadLine());
                //string[] s1 = Console.ReadLine().Split(' ');
                ////int[] arr = Array.ConvertAll(s1, int.Parse);
                ////string str = Console.ReadLine();
                //int i = 0;

                Node root = new Node(1);
                
               

            }
            Console.ReadLine();
        }

        public static void joinLevelNodes(Node root)
        {
            Queue<Node> queue1 = new Queue<Node>();
            Queue<Node> queue2 = new Queue<Node>();
            queue1.Enqueue(root);
            while(queue1.Count!=0 || queue2.Count != 0)
            {
                if (queue1.Count != 0)
                {
                    joinUtility(queue1, queue2);
                }

                if (queue2.Count != 0)
                {
                    joinUtility(queue2, queue1);
                }
            }
           
            
            

            
                
        }

        public static void joinUtility(Queue<Node> queue1, Queue<Node> queue2)
        {

            while (queue1.Count != 0)
            {
                Node n = queue1.Dequeue();
                Node queueTop = queue1.Peek();
                n.nextRight = queueTop;
                if (n.left != null)
                    queue2.Enqueue(n.left);
                if (n.right != null)
                    queue2.Enqueue(n.right);

            }

        }

     
       
    }
