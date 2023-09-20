public class Solution {
    public int[] PlusOne(int[] digits) {
        int carry = 1;
        for (int i = digits.Length - 1; i >= 0 && carry > 0; i--){
            digits[i] += carry;
            carry = digits[i] / 10;
            digits[i] %= 10;
        }

        if (carry > 0){
            int[] result = new int[digits.Length + 1];
            result[0] = carry;
            for (int i = 0; i < digits.Length; i++) 
                result[i + 1] = digits[i];
            digits = result;
        }
        return digits;
    }
}
