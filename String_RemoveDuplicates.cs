//Given a string, the task is to remove duplicates from it. Expected time complexity O(n) 
//where n is length of input string and extra space O(1) under the assumption that there are total 256 possible characters in a string.
// C# program to remove duplicates 
using System; 
using System.Collections.Generic; 
  
class GFG 
{ 
    /* Function removes duplicate characters  
    from the string. This function work in-place */
    void removeDuplicates(String str) 
    { 
        HashSet<char> lhs = new HashSet<char>(); 
        for(int i = 0; i < str.Length; i++) 
            lhs.Add(str[i]); 
          
        // print string after deleting  
        // duplicate elements 
        foreach(char ch in lhs) 
            Console.Write(ch); 
    } 
      
    // Driver Code 
    public static void Main(String []args) 
    { 
        String str = "geeksforgeeks"; 
        GFG r = new GFG(); 
        r.removeDuplicates(str); 
    } 
} 
