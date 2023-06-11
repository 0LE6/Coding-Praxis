// Simple algorithmic solution.

public static bool IsPalindome(int x){
        int rev = 0; 
        int num = x;
        bool positive = true;

        if (x < 0) positive = false;
        while (num > 0){
            rev = rev * 10 + num % 10;
            num /= 10;
        }
        return x == rev && positive;
    }
    
// Runtime 51 ms Beats 68.67% | Memory 29.2 MB Beats 94.16%

/* "One line return solution" 

public class Solution {
    public bool IsPalindrome(int x) {
        return Convert.ToString(new string(x.ToString().Reverse().ToArray())) == Convert.ToString(x);
    }
}

Runtime 57 ms Beats 43.67% | Memory 34.5 MB Beats 14.82% */

