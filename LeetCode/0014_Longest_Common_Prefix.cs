// Simple one return solution.

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string firstStr = strs[0];
        string str = "";
        if (strs.Length == 0) str = "";
        int i = 0;
        bool valid = true;
        while (i < firstStr.Length && valid)
        {
            char curChar = firstStr[i];

            for (int j = 1; j < strs.Length; j++)
            {
                string nextStr = strs[j];

                if (i >= nextStr.Length || nextStr[i] != curChar)
                    valid = false;
            }
            if (valid) str += curChar;
            i++;
        }
        return str;
    }
}

// Runtime 88 ms | Beats 97.27%
