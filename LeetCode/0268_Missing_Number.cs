// 2nd try, more efficient
public static int MissingNumber(int[] nums){
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != i) return i;
        }
        return nums.Length;
    }

// 1st try, not bad, simple solution
    public static int MissingNumber2(int[] nums){
        Array.Sort(nums); 
        int len = nums.Length; 
        int i = 0, miss = 0;;
        bool found = false;

        while (i < len && !found){
            if (nums[i] != i) {
                miss = i;
                found = true;
            }
            else miss = i + 1;
            i++;
        }

        return miss;
    }
