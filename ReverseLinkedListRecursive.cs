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

                ReverseLL(root);

            }
            Console.ReadLine();
        }
        public static Node newRoot;
        public static void ReverseLL(Node root)
        {
            Node rootNext = root.next;
            root.next = null;
            ReverseUtil(root, rootNext);
            Node s = newRoot;
            while (s != null)
            {
                Console.WriteLine(s.data);
                s = s.next;
            }
        }
        
        

        public static void ReverseUtil(Node p1, Node p2)
        {
            
            if (p2.next == null)            
                newRoot = p2;
            else
                ReverseUtil(p2, p2.next);
            p2.next = p1;
        }

        

        




    



}
