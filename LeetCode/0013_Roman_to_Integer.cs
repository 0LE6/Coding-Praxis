public class Solution {
    public int RomanToInt(string s) 
    {
        Dictionary<char, int> romanDic = new Dictionary<char, int>()
        {
            {'I', 1}, { 'V', 5 }, {'X', 10}, {'L', 50}, {'C', 100}, 
            {'D', 500}, {'M', 1000}
        };

        int sum = 0;
        int previous = 0;
        for (int i = s.Length -1; i >= 0; i--)
        {
            int actual = romanDic[s[i]];
            if (actual >= previous) sum += actual;
            else sum -= actual;
            previous = actual;
        }
        return sum;
    }
}
