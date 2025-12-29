public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        for(int i=0; i<nums.Length; i++){
           for(int j=i+1; j<nums.Length; j++){
            if(nums[i]+nums[j]==target){
                int[] answ=new int[] {i,j};
                return answ;
           }
            
        } 
           
    }return Array.Empty<int>();
}
}
