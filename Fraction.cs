using System;

namespace AndreaAngella
{
    public class Fraction : IEquatable<Fraction>
    {
        private readonly int m_Numerator;

        public Fraction(int numerator)
        {
            m_Numerator = numerator;
        }

        public static Fraction operator + (Fraction f1, Fraction f2)
        {
            return new Fraction(f1.m_Numerator + f2.m_Numerator);
        }

        public static implicit operator Fraction (int value)
        {
            return new Fraction(value);
        }

        public override string ToString()
        {
            return m_Numerator.ToString();
        }

        public bool Equals(Fraction other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return m_Numerator == other.m_Numerator;
        }

        public override bool Equals(object fraction)
        {
            return Equals((Fraction) fraction);
        }

        public override int GetHashCode()
        {
            return m_Numerator;
        }
    }
}
