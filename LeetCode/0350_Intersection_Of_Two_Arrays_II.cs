public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        List<int> intersection = new List<int>();
        int indexNums1 = 0, indexNums2 = 0;
        Array.Sort(nums1); Array.Sort(nums2);

        while (indexNums1 < nums1.Length && indexNums2 < nums2.Length) {
            if (nums1[indexNums1] == nums2[indexNums2]) {
                intersection.Add(nums1[indexNums1]);
                indexNums1++; indexNums2++;
            }
            else if (nums1[indexNums1] < nums2[indexNums2]) 
                indexNums1++;
            else indexNums2++;
        }

        return intersection.ToArray();
    }
}

// If there's a repeated number, it also adds it.
