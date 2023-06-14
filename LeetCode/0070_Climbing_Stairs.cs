public class Solution {
    public int ClimbStairs(int n) {
        int[] waysPerStair = new int[n+1];
        waysPerStair[0] = 1;
        waysPerStair[1] = 1;
        
        for (int i = 2; i <= n; i++) {
            waysPerStair[i] = waysPerStair[i-1] + waysPerStair[i-2];
        }
        return waysPerStair[n];
    }
}
