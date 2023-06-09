// "One line return solution" 

public class Solution {
    public bool IsPalindrome(int x) {
        return Convert.ToString(new string(x.ToString().Reverse().ToArray())) == Convert.ToString(x);
    }
}

