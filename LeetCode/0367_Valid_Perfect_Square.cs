// Binary Search solution

public class Solution {
    public bool IsPerfectSquare(int num) {
        long low = 1, high = num;
        while (low <= high) {
            long mid = low + (high - low) / 2;
            long sqr = mid * mid;
            if (sqr == num) return true;
            else if (sqr > num) high = mid - 1;
            else low = mid + 1; 
        }
        return false;
    }
}

// Slower solution

public class Solution {
    public bool IsPerfectSquare(int num) {
        if (num == 1) return true;
        
        long i = 1;
        while (i * i <= num) {
            if (i * i == num) {
                return true;
            }
            i++;
        }
        
        return false;
    }
}
