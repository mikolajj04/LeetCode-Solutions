//Given two strings s and goal, return true if and only if s can become goal after some number of shifts on s.
//A shift on s consists of moving the leftmost character of s to the rightmost position.

//For example, if s = "abcde", then it will be "bcdea" after one shift.

//Example 1:
//Input: s = "abcde", goal = "cdeab"
//Output: true

//Example 2:
//Input: s = "abcde", goal = "abced"
//Output: false

public class Solution {
    public bool RotateString(string s, string goal) {
        
     if(s.Length!=goal.Length){return false;}else{
        return (s+s).Contains(goal);
     }
        
    
    }
}

//(I concatenated the source string with itself because that way it gives us  all possible letter rotations, so then i can simply use string.Constains() function )
