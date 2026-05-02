//Given two strings s and t, determine if they are isomorphic.
//Two strings s and t are isomorphic if the characters in s can be replaced to get t.
//All occurrences of a character must be replaced with another character while preserving the order of characters. No two characters may map to the same character, but a character may map to itself.


//Example 1:
//Input: s = "egg", t = "add"
//Output: true
//Explanation:
//The strings s and t can be made identical by:
//Mapping 'e' to 'a'.
//Mapping 'g' to 'd'.
//Example 2:
//Input: s = "f11", t = "b23"
//Output: false
//Explanation:
//The strings s and t can not be made identical as '1' needs to be mapped to both '2' and '3'.
//Example 3:
//Input: s = "paper", t = "title"
//Output: true

public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if(s.Length!=t.Length){return false;}

        Dictionary<char, int> dicts = new Dictionary<char, int>();
        Dictionary<char, int> dictt = new Dictionary<char, int>();

        for(int i=0; i<s.Length; i++){
            char chars= s[i];
            char chart= t[i];

            if(!dicts.ContainsKey(chars)){
                dicts[chars]=i;

            }



            if(!dictt.ContainsKey(chart)){
                dictt[chart]=i;
                }

            if(dicts[chars]!=dictt[chart]){
                return false;
            }
        }
        return true;

    }
}