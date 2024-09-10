namespace MCDApp
{
    public static class MCDCalculador
    {
        public static int Calcular(int a, int b)
        {
            if(b == 0) return a;
        
            else
            return Calcular(b, a % b);
        }
        
    }
}