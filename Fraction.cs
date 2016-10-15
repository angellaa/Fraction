using System;

namespace AndreaAngella
{
    public class Fraction : IEquatable<Fraction>
    {
        private readonly int m_Numerator;
        private readonly int m_Denominator;

        public Fraction(int numerator) : this(numerator, 1)
        {
        }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0) throw new ArgumentException(nameof(denominator));
            if (numerator < 0) throw new NotImplementedException();
            if (denominator < 0) throw new NotImplementedException();

            var gcd = GreatestCommonDivisor(numerator, denominator);

            m_Numerator = numerator / gcd;
            m_Denominator = denominator / gcd;
        }

        public static Fraction operator + (Fraction f1, Fraction f2)
        {
            if (f1.m_Denominator == f2.m_Denominator)
            {
                return new Fraction(f1.m_Numerator + f2.m_Numerator, f1.m_Denominator);
            }

            if (f1.m_Denominator == 1)
            {
                return new Fraction(f1.m_Numerator*f2.m_Denominator + f2.m_Numerator, f2.m_Denominator);
            }

            if (f2.m_Denominator == 1)
            {
                return new Fraction(f1.m_Numerator + f2.m_Numerator * f1.m_Denominator, f1.m_Denominator);
            }

            var lowestCommonMultiple = LowestCommonMultiple(f1.m_Denominator, f2.m_Denominator);

            return new Fraction(f1.m_Numerator * lowestCommonMultiple / f1.m_Denominator + 
                                f2.m_Numerator * lowestCommonMultiple / f2.m_Denominator, 
                                lowestCommonMultiple);
        }

        private static int LowestCommonMultiple(int a, int b)
        {
            return a / GreatestCommonDivisor(a, b) * b;
        }

        private static int GreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        public static implicit operator Fraction (int value)
        {
            return new Fraction(value);
        }

        public override string ToString()
        {
            return m_Denominator == 1 ? $"{m_Numerator}" : $"{m_Numerator}/{m_Denominator}";
        }

        public bool Equals(Fraction other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return m_Numerator == other.m_Numerator && m_Denominator == other.m_Denominator;
        }

        public override bool Equals(object fraction)
        {
            return Equals((Fraction) fraction);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (m_Numerator*397) ^ m_Denominator;
            }
        }
    }
}
