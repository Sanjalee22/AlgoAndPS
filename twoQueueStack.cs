public static void Main(string[] args)
        {
            int noOfTC = Convert.ToInt32(Console.ReadLine());

            for (int t = 0; t < noOfTC; ++t)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                string[] s1 = Console.ReadLine().Split(' ');
                int[] arr = Array.ConvertAll(s1, int.Parse);
                //string str = Console.ReadLine();
                Queue<int> activequeue = new Queue<int>();
                Queue<int> subqueue = new Queue<int>();
                int i = 0;
                while(i<arr.Length)
                {
                    if(arr[i]==1)
                    {
                        PushInTwoQueueStack(activequeue, subqueue, arr[i + 1]);
                        i = i + 2;
                    }
                    else if(arr[i]==2)
                    {
                        int x = PopFromTwoQueueStack(activequeue, subqueue);
                        i = i + 1;
                    }
                }
                
                foreach (int x in activequeue)
                    Console.WriteLine(x);                
                Console.ReadLine();              

            }
        }

        public static void PushInTwoQueueStack(Queue<int> activeQueue, Queue<int> subQueue,int element)
        {
            activeQueue.Enqueue(element);
                 
        }
        public static int PopFromTwoQueueStack(Queue<int> activeQueue, Queue<int> subQueue)
        {
            int count = activeQueue.Count;
            if (count == 0)
                return -1;
            while (count > 1)
                subQueue.Enqueue(activeQueue.Dequeue());
            int res= activeQueue.Dequeue();
           
            //Swap the two queues

            Queue<int> temp = activeQueue;
            activeQueue = subQueue;
            subQueue = temp;

            return res;

        }
