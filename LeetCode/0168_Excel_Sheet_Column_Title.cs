public class Solution {
    public string ConvertToTitle(int columnNumber) {
        StringBuilder sb = new StringBuilder();
        while (columnNumber-- > 0){
            char letter = (char)((columnNumber % 26) + 65);
            sb.Append(letter);
            columnNumber /= 26;
        }
        char[] letterArray = sb.ToString().ToCharArray();
        Array.Reverse(letterArray);

        return new string(letterArray);
    }

    /* Another solution approach:

    StringBuilder sb = new StringBuilder();
        while (columnNumber > 0){
            char letter = (char)(((columnNumber - 1) % 26) + 65);
            sb.Insert(0, letter);
            columnNumber = (columnNumber - 1) / 26;
        }
        return sb.ToString();

    */
}
