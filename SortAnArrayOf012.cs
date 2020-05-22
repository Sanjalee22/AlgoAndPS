class Program
    {
        
        public static void Main(string[] args)
        {
            int noOfTC = Convert.ToInt32(Console.ReadLine());

            for (int t = 0; t < noOfTC; ++t)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                string[] s1 = Console.ReadLine().Split(' ');
                int[] arr = Array.ConvertAll(s1, int.Parse);
                //string str = Console.ReadLine();
                Sort012Array(arr);
                foreach (int x in arr)
                    Console.WriteLine(arr);                
                Console.ReadLine();              

            }
        }

        public static void Sort012Array(int[] arr)
        {
            int l = 0, m = 0, h = arr.Length - 1;
            while(m<=h)
            {
                if (arr[m] == 0)
                {
                    Swap(arr, m, l);
                    l++;
                }
                else if (arr[m] == 2)
                {
                    Swap(arr, m, h);
                    h--;
                }
                m++;
            }
                 
        }

        public static void Swap(int[] arr, int pos1, int pos2)
        {
            int temp = arr[pos1];
            arr[pos1] = arr[pos2];
            arr[pos2] = temp;
        }







    }
