Class Program
{
  public static void Main()
  {
  
  }
  
  public static void FourElementsSum(int[] arr, int k)
        {
            Dictionary<int, Pair> map = new Dictionary<int, Pair>();
            string res = "";
            for(int i = 0; i < arr.Length; ++i)
            {
                for(int j = i + 1; j < arr.Length; ++j)
                {
                    int pairSum = arr[i] + arr[j];
                    if (map.ContainsKey(pairSum))
                    {
                        map[pairSum] = new Pair(arr[i], arr[j]);
                    }
                    else
                    {
                        map.Add(pairSum, new Pair(arr[i], arr[j]));
                    }
                }
            }

            foreach(KeyValuePair<int,Pair> kvp in map)
            {
                int x = k - kvp.Key;
                //now if the map contains x, then x and kvp.Key values  will be the 4 numbers.
                if (map.ContainsKey(x))
                {
                    res = kvp.Value.first + " " + kvp.Value.second + " " + map[x].first + " " + map[x].second;
                    Console.WriteLine(res);
                    break;
                }
            }

            if (res == "")
                Console.WriteLine("No such elements");
        }
}
 class Pair
    {
        public int first;
        public int second;
        public Pair(int first, int second)
        {
            this.first = first;
            this.second = second;
        }
    }
