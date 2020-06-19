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

                int[] arr = new int[] { 1, 1, 1, 1 };
                DistinctElementInWindow(arr, 3);
            }
            Console.ReadLine();
        }

        public static void DistinctElementInWindow(int[] arr, int k)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();

            //traverse through the first window
            int i = 0, j = 0;
            int count = 0;
            while (j < k)
            {
                if (!d.ContainsKey(arr[j]))
                {
                    d.Add(arr[j], 1);
                    count++;
                }
                else
                {
                    d[arr[j]]++;
                }

                ++j;
            }

            Console.WriteLine(count);

           
            //now at this point, i=0 and j=k. in first pass of the below loop, we will first manage the count of the ith element and then remove it
            //from the window. then as j is already at k, i.e. included in the window but it's count is not managed. we will manage it's count.
            //so the below loop at the end of every pass, j is included but count not managed. and window size is k+1. 
            while (j < arr.Length)
            {
                
                if (d[arr[i]] == 1)
                {
                    d.Remove(arr[i]);
                    count--;
                }
                else
                {
                    d[arr[i]]--;
                }
                i = i + 1;

                if (!d.ContainsKey(arr[j]))
                {
                    d.Add(arr[j], 1);
                    count++;
                }
                else
                {
                    d[arr[j]]++;
                }
                ++j;
                Console.WriteLine(count);
            }
        }   
       
    }
