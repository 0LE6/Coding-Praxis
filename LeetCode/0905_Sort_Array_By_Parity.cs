// https://leetcode.com/problems/sort-array-by-parity/
// Simple and quick solution.

public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        List<int> result = new List<int>();
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] % 2 == 0) result.Insert(0, nums[i]);
            else result.Add(nums[i]);
        }
        return result.ToArray();
    }
}
