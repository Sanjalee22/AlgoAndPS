public class Solution {
    public int Jump(int[] nums) {
        int n=nums.Length;
        int[] res = new int[n];
        res[0]=0;
        for(int i=1;i<n;++i)
        {
            res[i]=int.MaxValue;
            for(int j=i-1;j>=0;--j)
            {                
                if(j+nums[j]>=i)
                {                    
                    res[i]=Math.Min(res[i],res[j]+1);                    
                }
            }
        }
        return res[n-1];
    }
}
