/* Newton-Raphson method*/

public class Solution {
    public int MySqrt(int x) {
        long i = 0;
        while (i * i <= x){
            i++;
        }
        return (int)i - 1;
    }
}
