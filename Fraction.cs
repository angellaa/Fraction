using System;

namespace AndreaAngella
{
    public class Fraction : IEquatable<Fraction>
    {
        private readonly int m_Numberator;

        public Fraction(int numberator)
        {
            m_Numberator = numberator;
        }

        public static Fraction operator + (Fraction f1, Fraction f2)
        {
            return new Fraction(0);
        }

        public bool Equals(Fraction other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return m_Numberator == other.m_Numberator;
        }

        public override bool Equals(object fraction)
        {
            return Equals((Fraction) fraction);
        }

        public override int GetHashCode()
        {
            return m_Numberator;
        }
    }
}
