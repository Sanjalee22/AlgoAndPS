//The idea is if we find a ladder which takes us farther than current ladder, update our ladder. But keep decreasing the stairs from the current ladder
// until it becomes zero. After that, jump on to next ladder which we are keeping updated as soon as we find a ladder which is longer than our current ladder.
//Increment the jump variable when you change the ladder.
public class Solution {
    public int Jump(int[] nums) {
    
    if(nums.Length<=1)
        return 0;
        int ladder=nums[0]; //first ladder being the firt number
        int stairs=nums[0]; // number of steps initially
        int jump=1; //by default, at least one jump has to be made to reach end.
        for(int level=1;level<nums.Length;++level)
        {
            if(level==nums.Length-1) //if you have reached the end
                return jump;
            if(level+nums[level]>ladder) //if the current level has a ladder which is longer than available ladder, update ladder
                ladder=level+nums[level];
            stairs--; //but keep using the stairs of available ladder before using the updated ladder. 
            if(stairs==0) //if you have exhausted the existing stairs
            {
                jump++; //update jump because now you are jumping to 
                stairs=ladder-level; //update stairs with new ladder.
            }
        }
        return jump;
    }

}
