//Inversion Count : For an array, inversion count indicates how far (or close) the array 
//is from being sorted. If array is already sorted then inversion count is 0. If array is sorted in 
//reverse order that inversion count is the maximum. 
//Formally, two elements a[i] and a[j] form an inversion if a[i] > a[j] and i < j.

class Program
    {
        public static int count = 0;
        public static void Main(string[] args)
        {
            int noOfTC = Convert.ToInt32(Console.ReadLine());
            for (int t = 0; t < noOfTC; ++t)
            {
                //int num = Convert.ToInt32(Console.ReadLine());
                string[] s1 = Console.ReadLine().Split(' ');
                int[] startArray = Array.ConvertAll(s1, int.Parse);
                InversionCount(startArray);

                Console.WriteLine(count);
                Console.ReadLine();
            }
        }

        public static void InversionCount(int[] ar)
        {
            MergeSort(ar, 0, ar.Length - 1);
        }
        public static void MergeSort(int[] ar, int l, int r)
        {
            if (l < r) //else it would keep calling MergeSort even for single element, like when the array is divided into 1 element each. like MS(0,0)
            {
                int m = l + (r - l) / 2;
                MergeSort(ar, l, m);
                MergeSort(ar, m + 1, r);
                Merge(ar, l, m, r);
            }
            
        }
        public static void Merge(int[] ar, int l, int m, int r)
        {

            int n1 = m - l + 1;
            int n2 = r - m;
            int[] leftSorted = new int[n1];
            int[] rightSorted = new int[n2];
            int i;

            //copy array elements in temp arrays
            for ( i = 0; i <n1; ++i)
                leftSorted[i] = ar[l+i];
            for (i = 0; i < n2 ;++i)
                rightSorted[i] = ar[m+1+i];

            int j = 0, k = 0;
            i = l;
            while(j<n1 && k<n2)
            {
                if(leftSorted[j]<=rightSorted[k])
                {
                    ar[i] = leftSorted[j];
                   
                    ++j;
                }
                else
                {
                    ar[i] = rightSorted[k];
                   
                    ++k;
                    count = count + (n1-j);
                    // so when you copy an element from right subarray into main array, it means
                    // that it is smaller than all the remaining elemnts in left subarray, but it appears after 
                    //them in main unsorted array because thats how it ended
                    //up being in the right array.
                    //hence add the number of remaining elements in the left array to count.
                }
                ++i;
            }
            //you don't have to copy the remaining elements now because its not sorting, its just inversion count.
            //so if there are elements left in right subarray, that means that they are greater than all the elements and are correctly in right array
            //but if there are elements left in left array, they are also greater than all the elements but they have been counted while copying the
            //elements from right array.

        }
}
