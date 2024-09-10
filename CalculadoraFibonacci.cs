namespace CalcuFibonacci
{
    public static class FibonacciCalculadora
    {
        public static int Calcular(int n)
        {
            if(n <= 1)
                return n;
            else
                return Calcular(n - 1) + Calcular(n - 2);
        }
    }
}