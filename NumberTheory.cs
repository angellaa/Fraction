namespace AndreaAngella
{
    public class NumberTheory
    {
        public static int LowestCommonMultiple(int a, int b)
        {
            return a / GreatestCommonDivisor(a, b) * b;
        }

        public static int GreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }

            return Abs(a);
        }

        public static int Abs(int a)
        {
            return a > 0 ? a : -a;
        }
    }
}