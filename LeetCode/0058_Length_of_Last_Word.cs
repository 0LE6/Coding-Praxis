public class Solution {
    public int LengthOfLastWord(string s) {
        int res = 0;
        bool last = false;
        int i = s.Length - 1;
        while (i >= 0 && !last){
            if (s[i] != ' ') res++;
            else if (res > 0) last = true;
            i--;
        }
        return res;
    }
}
