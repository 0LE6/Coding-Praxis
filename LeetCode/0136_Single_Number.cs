// Using XOR

public static int SingleNumber(int[] nums){
        int unique = 0;
        foreach (int num in nums) unique ^= num; 
        return unique;
    }

// Sorting solution:

public static int SingleNumber(int[] nums){
        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 1; i += 2){
            if (nums[i] != nums[i + 1]) return nums[i];
        }

        return nums[nums.Length - 1]; 
    }
