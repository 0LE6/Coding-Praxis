public class Solution {
    public string ReverseWords(string s) {
        StringBuilder result = new StringBuilder();
        StringBuilder currentWord = new StringBuilder();

        foreach (char c in s) {
            if (c != ' ') currentWord.Insert(0, c);
            else {
                result.Append(currentWord);
                result.Append(' ');
                currentWord.Clear(); 
            }
        }
        result.Append(currentWord);

        return result.ToString();
    }
}
