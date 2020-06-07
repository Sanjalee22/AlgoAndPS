class Program
    {

        public static Stack<int> mainStack;
        public static Stack<int> minStack;
        public static void Main(string[] args)
        {
            mainStack = new Stack<int>();
            minStack = new Stack<int>();
            int noOfTC = Convert.ToInt32(Console.ReadLine());
             
            for (int t = 0; t < noOfTC; ++t)
            {
                //int num = Convert.ToInt32(Console.ReadLine());
                string[] s1 = Console.ReadLine().Split(' ');
                //int[] arr = Array.ConvertAll(s1, int.Parse);
                //string str = Console.ReadLine();
                int i = 0;
                while(i<s1.Length)
                {
                    if (s1[i] == "1")
                    {
                        Push(Convert.ToInt32(s1[i + 1]));
                        i = i + 2;
                    }

                    else if (s1[i] == "2")
                    {
                        Console.WriteLine(Pop());
                        ++i;
                    }
                    else if(s1[i]=="3")
                    {
                        Console.WriteLine(minStack.Peek());
                        ++i;
                    }


                }

            }
            Console.ReadLine();
        }

        public static void Push(int n)
        {
            mainStack.Push(n);
            if (minStack.Count == 0 || n < minStack.Peek())
                minStack.Push(n);
        }

        public static int Pop()
        {
            if (mainStack.Count == 0)
                throw new Exception("Stack Empty");
            int n = mainStack.Pop();
            if (minStack.Peek() == n)
                minStack.Pop();
            return n;
        }        
       
    }
