public class Solution {
    public string IntToRoman(int num) {
        Dictionary<string, int> lexiko = new Dictionary<string, int>(){
            {"M", 1000}, {"CM", 900}, {"D", 500}, {"CD", 400},
            {"C", 100}, {"XC", 90}, {"L", 50}, {"XL", 40},
            {"X", 10}, {"IX", 9}, {"V", 5}, {"IV", 4}, {"I", 1}
        };

        StringBuilder result = new StringBuilder();

        foreach (KeyValuePair<string,int> romanNum in lexiko){
            while (num >= romanNum.Value){
                result.Append(romanNum.Key);
                num -= romanNum.Value;
            }
        }

        return result.ToString();
    }
}
