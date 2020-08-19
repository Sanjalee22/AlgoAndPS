//Find the element that appears once in sorted array
public static void Main(string[] args)
        {
            int noOfTC = Convert.ToInt32(Console.ReadLine());
            for (int t = 0; t < noOfTC; ++t)
            {
                //int num = Convert.ToInt32(Console.ReadLine());
                string[] s1 = Console.ReadLine().Split(' ');
                int[] startArray = Array.ConvertAll(s1, int.Parse);
                int ans = FindNonRepeatingElement(startArray);
                int p = startArray[ans];
                Console.WriteLine(p);
                Console.ReadLine();
            }
        }

        public static int FindNonRepeatingElement(int[] ar)
        {
            int l, h, m;
            l = 0;
            h = ar.Length - 1;

            while(l<=h)
            {
                m = (l + h) / 2;

                //corner cases
                if (m == 0 || m == ar.Length - 1)
                    return m;

                //check if ar[m] is non repeating
                if (ar[m] != ar[m - 1] && ar[m] != ar[m + 1])
                    return m;

                //if m is odd then there can be two cases based on 
                //whether the non repeating number is at index >m or <m eg. 1 2 2 3 3 4 4  or 1 1 2 2 3 3 4
                if (m % 2 != 0)
                {
                    if (ar[m] == ar[m - 1])
                        l = m + 1;
                    else
                        h = m - 1;
                }

                //similarly if m is even then there can be two cases based on 
                //whether the non repeating number is at index >m or <m
                else
                {
                    if (ar[m] == ar[m - 1])
                        h = m - 2;
                    else
                        l = m + 2;
                }

            }

            return -1;
        }
