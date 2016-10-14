﻿using System;

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
            m_Numerator = numerator;
            m_Denominator = denominator;            
        }

        public static Fraction operator + (Fraction f1, Fraction f2)
        {
            return new Fraction(f1.m_Numerator + f2.m_Numerator, f2.m_Denominator);
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
