public static bool DistinctElementInWindow(int[] arr, int k)
        {
            Dictionary<int, int> remainderFreq = new Dictionary<int, int>();

            if (arr.Length % 2 != 0)
                return false;

            for(int i=0;i<arr.Length;++i)
            {
                int remainder = arr[i] % k;
                if (remainderFreq.ContainsKey(remainder))
                    remainderFreq[remainder]++;
                else
                    remainderFreq.Add(remainder, 1);
            }

            //if there is a remainder with value k/2 or zero. It should be even number of times eg. 9 and 3 when k is 6          

            foreach (KeyValuePair<int,int> kvp in remainderFreq)
            {
                if ((k==2*kvp.Key) || kvp.Key == 0)
                {
                    if (remainderFreq[kvp.Key] % 2 != 0)
                        return false;
                }

                if (remainderFreq[kvp.Key] != remainderFreq[k - kvp.Key])
                    return false;                
            }
            return true;           
        }   
