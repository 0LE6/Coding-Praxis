public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> set1 = new HashSet<int>(nums1);
        HashSet<int> intersection = new HashSet<int>();

        foreach (int num in nums2) {
            if (set1.Contains(num)) {
                intersection.Add(num);
            }
        }

        return intersection.ToArray();
    }
}
