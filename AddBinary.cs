//Given two binary strings a and b, return their sum as a binary string.

 

//Example 1:

//Input: a = "11", b = "1"
//Output: "100"
//Example 2:

//Input: a = "1010", b = "1011"
//Output: "10101"
 

public class Solution {
    public string AddBinary(string a, string b) {
        StringBuilder sb= new StringBuilder();
        int i = a.Length -1;
        int j = b.Length - 1;
        int carry = 0;
        while(i>= 0 || j>=0 || carry > 0){
            int sum= carry;
            if(i>=0){
                sum+= a[i] - '0';
                i--;
            }
            if(j>=0){
                sum+= b[j] - '0';
                j--;
            }
            sb.Append(sum%2);
            carry = sum/2;
        }

        char[] charArray = sb.ToString().ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
