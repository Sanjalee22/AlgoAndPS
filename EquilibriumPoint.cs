//Given an array A of N positive numbers. The task is to find the position where equilibrium first occurs in the array. 
//Equilibrium position in an array is a position such that the sum of elements before it is equal to the sum of elements after it.

//The logic here is first sum all the elements, lets call it Sum. 
//Then start looping through the array again
//In every pass i, substract that element from the Sum. This way you have sum of all elements to the right of arr[i]
//now keep a leftsum initialized as zero. now, with e very pass, keep adding the element arr[i] to leftsum. This way you have the sum
//of elements till arr[i] and sum of elements after arr[i].
//Also, before adding arr[i] to leftsum, check if leftsum==current sum Sum. If yes, return i.

class GFG { 
    static int equilibrium(int[] arr, int n) 
    { 
        // initialize sum of whole array 
        int sum = 0; 
  
        // initialize leftsum 
        int leftsum = 0; 
  
        /* Find sum of the whole array */
        for (int i = 0; i < n; ++i) 
            sum += arr[i]; 
  
        for (int i = 0; i < n; ++i) { 
  
            // sum is now right sum 
            // for index i 
            sum -= arr[i]; 
  
            if (leftsum == sum) 
                return i; 
  
            leftsum += arr[i]; 
        } 
  
        /* If no equilibrium index found,  
        then return 0 */
        return -1; 
    } 
  
    // Driver code 
    public static void Main() 
    { 
        int[] arr = { -7, 1, 5, 2, -4, 3, 0 }; 
        int arr_size = arr.Length; 
  
        Console.Write("First equilibrium index is " + 
                           equilibrium(arr, arr_size)); 
    } 
} 
