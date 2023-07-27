public static bool IsPalindrome(string s){
    StringBuilder sb = new StringBuilder();
    for(int i = 0; i < s.Length; i++){
        if (char.IsLetterOrDigit(s[i])) sb.Append(char.ToLower(s[i]));
        
    }
    return sb.ToString().Equals(new string(sb.ToString().Reverse().ToArray()));
}
