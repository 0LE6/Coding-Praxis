// XOR solution

public class Solution {
    public char FindTheDifference(string s, string t) {
        int charCode = 0;

        foreach (char c in s) {
            charCode ^= (int)c;
        }

        foreach (char c in t) {
            charCode ^= (int)c;
        }

        return (char)charCode;
    }
}
