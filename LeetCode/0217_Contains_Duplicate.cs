// Time 0(n) / Space 0(n)
public static bool ContainsDuplicate(int[] nums) {
    HashSet<int> set = new HashSet<int>(nums);
    return set.Count != nums.Length ? true : false; // Ternary not necessary
}

// Time 0(n * log(n)) / Space 0(n)
public static bool ContainsDuplicate2(int[] nums) {
    Array.Sort(nums);
    bool twice = false; int i = 1;
    while (i < nums.Length && !twice) {
        twice = nums[i - 1] == nums[i];
        i++;
    }
    return twice;
}
