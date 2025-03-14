namespace TitanUtilsLib.Utils
{
    public static class MathUtils
    {
        public static long Factorial(int n) => (n < 0) ? throw new ArgumentException("Negative numbers not allowed.") : (n == 0 ? 1 : n * Factorial(n - 1));

        public static bool IsPrime(int num) => num >= 2 && Enumerable.Range(2, (int)Math.Sqrt(num) - 1).All(i => num % i != 0);

        public static double Distance(double x1, double y1, double x2, double y2) =>
            Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }
}
