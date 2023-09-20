public class Solution {
    public int MajorityElement(int[] nums) {
        Array.Sort(nums);
        int currNum = nums[0];
        int reps = 1;
        int currReps = 1;

        for (int i = 1; i < nums.Length; i++){
            if (nums[i] == nums[i - 1]){
                currReps++;

                if (currReps > reps){
                    reps = currReps;
                    currNum = nums[i];
                }
            }
            else currReps = 1;
        }
        return currNum;
    }
}
