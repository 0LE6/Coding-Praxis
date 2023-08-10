// My first solution:

public class Solution {
    public int TitleToNumber(string columnTitle) {
        Dictionary<char, int> excel = new Dictionary<char, int>()
        {
            {'A', 1}, {'B', 2}, {'C', 3}, {'D', 4}, {'E', 5}, {'F', 6},
            {'G', 7}, {'H', 8}, {'I', 9}, {'J', 10}, {'K', 11}, {'L', 12},
            {'M', 13}, {'N', 14}, {'O', 15}, {'P', 16}, {'Q', 17}, {'R', 18},
            {'S', 19}, {'T', 20}, {'U', 21}, {'V', 22}, {'W', 23}, {'X', 24},
            {'Y', 25}, {'Z', 26}
        };

        int pow = 0, res = 0;
        for (int i = columnTitle.Length -1; i >= 0; i--){
            res += excel[columnTitle[i]] * (int)(Math.Pow(26,pow));
            pow++;
        }

        return res;
    }

  /* Easier approach:
    int res = 0;
        for (int i = 0; i < columnTitle.Length; i++) {
            int val = columnTitle[i] - 65 + 1;
            res = res * 26 + val;
        }
        return res;
  */
}
