//Given an array of positive integers. Your task is to find the leaders in the array.
//Note: An element of array is leader if it is greater than or equal to all the elements to its right side. 
//Also, the rightmost element is always a leader. 
class LeadersInArray { 
      
    // C# Function to print leaders 
    // in an array  
    void printLeaders(int []arr, int size) 
    { 
        int max_from_right = arr[size - 1]; 
  
        // Rightmost element is always leader 
        Console.Write(max_from_right +" "); 
      
        for (int i = size - 2; i >= 0; i--) 
        { 
            if (max_from_right < arr[i]) 
            {      
                max_from_right = arr[i]; 
                Console.Write(max_from_right +" "); 
            } 
        }  
    } 
  
    // Driver Code 
    public static void Main(String[] args)  
    { 
        LeadersInArray lead = new LeadersInArray(); 
        int []arr = new int[]{16, 17, 4, 3, 5, 2}; 
        int n = arr.Length; 
        lead.printLeaders(arr, n); 
    } 
} 
