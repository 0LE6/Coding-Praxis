// My first quick solution with basic RECURSION knowledge (poor efficienty)
    public static int Fib(int n){

        if (n > 1){
            return Fib(n - 1) + Fib(n - 2);
        }
        return n;
    }

    // Solution using BINOMIAL FORMULA
    public static int Fib2(int n){
        // F(n) = (phi^n - (-phi)^(-n)) / sqrt(5)
        double phi = (1 + Math.Sqrt(5)) / 2;
        return (int)Math.Round(Math.Pow(phi, n) / Math.Sqrt(5));
    }

    // Solution with more SIMPLE APPROACH
    public static int Fib3(int n){
        if (n < 2) return n;
        
        int prev = 0, curr = 1;
        
        for (int i = 2; i <= n; i++) {
            int next = prev + curr;
            prev = curr;
            curr = next;
        }
        
        return curr;
    }

    // Solution using MEMORIZATION (good efficiency)
    public static int Fib4(int n) {
        Dictionary<int, int> memo = new Dictionary<int, int>();
        if (n < 2) return n;

        if (memo.ContainsKey(n))
            return memo[n];

        int fib = Fib4(n - 1) + Fib4(n - 2);
        memo[n] = fib;

        return fib;
    }
