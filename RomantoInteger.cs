//Given a roman numeral, convert it to an integer.
//Example 1:
//Input: s = "III"
//Output: 3
//Explanation: III = 3.

//Example 2:
//Input: s = "LVIII"
//Output: 58
//Explanation: L = 50, V= 5, III = 3.


public class Solution {
    public int RomanToInt(string s) {
        
            Dictionary<char, int> roman= new Dictionary<char, int>{

                {'I', 1},
                {'V' ,5},
                {'X' ,10},
                {'L', 50},
                {'C',100},          
                {'D',500},
                {'M',1000}
            };
            int total = 0;
            for (int i=0; i<s.Length; i++){
                if(i+1<s.Length && roman[s[i]]< roman[s[i+1]]){
                    total-=roman[s[i]];
                }else{
                    total+=roman[s[i]];
                }
            }
            return total;


    }
}
