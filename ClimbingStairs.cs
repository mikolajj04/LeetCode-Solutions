//You are climbing a staircase. It takes n steps to reach the top.
//Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?


public class Solution {
    public int ClimbStairs(int n) {
        if(n<=2){
            return n;
        }else{
            int a=1;
            int b=1;
            int c=a+b;
            for(int i=0; i<n-2; i++){
                a=b;
                b=c;
                c=a+b;
               
            }
            return c;
        }

    }
}
