//Find a triplet such that sum of two equals to a third element in the array
public static void Main(string[] args)
        {
            int noOfTC = Convert.ToInt32(Console.ReadLine());
            for (int t = 0; t < noOfTC; ++t)
            {
                //int num = Convert.ToInt32(Console.ReadLine());
                string[] s1 = Console.ReadLine().Split(' ');
                int[] startArray = Array.ConvertAll(s1, int.Parse);
                int ans = FindTripletSum(startArray);

                Console.WriteLine(ans);
                Console.ReadLine();
            }
        }

        public static int FindTripletSum(int[] ar)
        {
            if (ar.Length <= 2)
                return -1;
            Array.Sort(ar);
            int k = ar.Length - 1;

            int totalTriplet = 0;
            while (k >= 2)
            {
                int i = 0;
                int j = k - 1;
                while (i < j)
                {
                    if (ar[i] + ar[j] > ar[k]) // decrease j to see if ar[k] can be found with smaller elements
                        j--;
                    else if (ar[i] + ar[j] < ar[k])
                        i++;
                    else
                    {
                        totalTriplet++;
                        i++;
                        j--; // inc i and dec j to see if any more elemnts exist who sum up to k
                    }
                }
                k--;
            }
            return totalTriplet;
        }
