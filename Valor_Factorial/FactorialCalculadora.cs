namespace FactorialCalculator
{
    public static class FactorialCalculator
    {
        public static long Calculate(int n)
        {
            if (n <= 1)
                return 1;
            else
                return n * Calculate(n - 1);
        }
    }
}
