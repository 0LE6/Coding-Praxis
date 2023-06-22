/* Newton-Raphson method */

public class Solution {
    public int MySqrt(int x) {
        long i = 0;
        while (i * i <= x){
            i++;
        }
        return (int)i - 1;
    }
}

/*  
>> Using C# Math.Sqrt() Method

public class Solution {
    public int MySqrt(int x) {
        return (int)Math.Sqrt(x);
    }
}

>> Fastest solution:
public class Solution {
    public int MySqrt(int x) => (int)Math.Sqrt(x);
}
*/
