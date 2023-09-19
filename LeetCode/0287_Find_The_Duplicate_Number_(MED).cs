public class Solution {
    public int FindDuplicate(int[] nums) {
        int first = nums[0], second = nums[0];
        bool keep = true;

        while (keep) {
            first = nums[first];
            second = nums[nums[second]];
            if (first == second) keep = false;
        }

        int num1 = nums[0], num2 = second;

        while (num1 != num2) {
            num1 = nums[num1];
            num2 = nums[num2];
        }
        return num1;

        // Floyd's Tortoise and Hare Algorithm
    }
}
