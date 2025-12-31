//Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
//Input: haystack = "sadbutsad", needle = "sad"
//Output: 0
public class Solution {
    public int StrStr(string haystack, string needle) {
        int indeks = haystack.IndexOf(needle);
        return indeks;
    }
}
