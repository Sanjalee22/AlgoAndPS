//Check if the array elements can be partitioned into two equal sum arrays.
//In this solutin, we basically see that if there exists elements in the array who sum up to sum/2. If thats possible, we know that the array can be partitioned in two equal 
//sum subsets. This is a generic solution. So if you replace sum/2 with any number k, you can check if te array has a subset whose sum is k.
public bool CanPartition(int[] nums) {
        
        //calculate the sum
        int n=nums.Length;
        int sum=0;
        for(int i=0;i<n;++i){
            sum=sum+nums[i];
        }
         
        //if sum is odd, return false
        if(sum%2!=0)
            return false;
        
        //get the half of sum
        sum=sum/2;
        
        //sort the array nums
        //Array.Sort(nums);
        
        //create a solution array 
        bool[,] solution=new bool[n,sum+1];
        
        //set first column as true as it is possible to get zero sum with an empty set
        for(int i=0;i<n;++i)
            solution[i,0]=true;
        
        //set first row based on nums[0]
        
        for(int j=1;j<=sum;++j)
        { 
            if(j==nums[0])
               solution[0,j]=true;
            else
                solution[0,j]=false;
         }
        
        //now loop through all the possible sums for all the elements
        
        //for every element in nums
        for(int i=1;i<n;++i)
        {
            for(int j=1;j<=sum;++j)
            {
                //if this column element is less that the current row element, set false
                if(j<nums[i])
                    solution[i,j]=solution[i-1,j];
                else
                {
                    //if the current sum is possible with already included numbers
                    if(solution[i-1,j])
                        solution[i,j]=true;
                    
                    //else check if current sum - current num is true, then current sum is also
                    //true if we include this number
                    else
                        solution[i,j]=solution[i-1,j-nums[i]];
                }
            }
            
            //return as soon as the sum is found possible. No need to loop further.
            if(solution[i,sum])
                return true;
        }
        
        return solution[n-1,sum];
        
    }
