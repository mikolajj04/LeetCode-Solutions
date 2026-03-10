//Write a function to find the longest common prefix string amongst an array of strings.

//If there is no common prefix, return an empty string "".

 

//Example 1:
//Input: strs = ["flower","flow","flight"]
//Output: "fl"

//Example 2:
//Input: strs = ["dog","racecar","car"]
//Output: ""

 

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs.Length==0) return "";
        string FirstString = strs[0];
        for (int i=0; i<FirstString.Length; i++){
            char c= FirstString[i];
            for(int j=1; j<strs.Length; j++){
                if(i==strs[j].Length || c!=strs[j][i]){
                    return FirstString.Substring(0, i);
                }

            }

        }
        return FirstString;
    }
}
