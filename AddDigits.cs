//Given an integer num, repeatedly add all its digits until the result has only one digit, and return it.

 
//Example:
//Input: num = 38
//Output: 2
//Explanation: The process is
//38 --> 3 + 8 --> 11
//11 --> 1 + 1 --> 2 
//Since 2 has only one digit, return it.



public class Solution {
    public int AddDigits(int num) {
     
        int sum = num;
        if (num == 0) return 0;
        string numString =num.ToString();
        while (numString.Length > 1)
        {
          sum=0;  

            for (int i = 0; i < numString.Length; i++)
            {
                sum += int.Parse(numString[i].ToString());
            }
            numString = sum.ToString();            
        }
        return sum; 
    }
}
