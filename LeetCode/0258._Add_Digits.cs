public class Solution {
    public int AddDigits(int num) {
        // The more eficient way O(1): digital root formula + ternary operator
        return num == 0 ? 0 : 1 + (num - 1) % 9;
    }
}
