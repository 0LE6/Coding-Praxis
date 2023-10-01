public class Solution {
    public bool IsMonotonic(int[] nums) {
        bool isIncreasing = true;
        bool isDecreasing = true;

        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] < nums[i - 1]) isIncreasing = false;
            else if (nums[i] > nums[i - 1]) isDecreasing = false;

            if (!isIncreasing && !isDecreasing) return false;
        }
        return isIncreasing || isDecreasing;
    }
}
