public class Solution {
    public int[] TwoSum(int[] nums, int target) { 
        Dictionary<int, int> numsDic = new Dictionary<int, int>();

        int[] result = { 0, 0 };
        for (int i = 0; i < nums.Length; i++)
        {
            int difference = target - nums[i];
            if (numsDic.ContainsKey(difference))
            {
                result[0] = numsDic[difference];
                result[1] = i;
            }
            numsDic[nums[i]] = i;
        }
        return result;
    }
}

// Runtime 145 ms | Memory 44.8 MB
