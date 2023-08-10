public class Solution {
    public bool Search(int[] nums, int target) {
        List<int> list = new List<int>(nums);
        bool contains = false;
        if(list.Contains(target)) contains = true;
        return contains;
    }
}
