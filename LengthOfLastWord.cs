//Given a string s consisting of words and spaces, return the length of the last word in the string.
//A word is a maximal substring consisting of non-space characters only.
//Input: s = "Hello World"
//Output: 5

public class Solution {
    public int LengthOfLastWord(string s) {
        s= s.Trim();
        int length=0;
        for(int i=s.Length-1; i>=0; i--){
            if(s[i]!=' '){
                length++;
            }else{
                break;
            }
        
        }
        return length;
        }
    } 
