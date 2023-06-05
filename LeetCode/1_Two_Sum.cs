public class Solution {
    public int[] TwoSum(int[] nums, int target) { 
        Dictionary<int, int> numsDic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int difference = target - nums[i];
            if (numsDic.ContainsKey(difference))
            {
                return new int[] { numsDic[difference], i };
            }
            numsDic[nums[i]] = i;
        }
        return new int[0];
    }
}

// Runtime 145 ms | Memory 44.8 MB
