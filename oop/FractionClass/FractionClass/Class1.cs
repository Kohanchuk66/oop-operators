using System;

namespace FractionClass
{
    public class Fraction
    {
        public long Numerator, Denominator;
        public Fraction(long Num, long Denum)
        {
            Numerator = Num;
            Denominator = Denum;
            
        }
        public Fraction(long Num)
        {
            Numerator = Num;
            Denominator = 1;
        }
        public Fraction(Fraction a)
        {
            Numerator = a.Numerator;
            Denominator = a.Denominator;
        }
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
        public static Fraction operator + (Fraction a)
        {
            return new Fraction(a);
        }
        public static Fraction operator - (Fraction a)
        {
            return new Fraction(-a.Numerator,a.Denominator);
        }
        public static Fraction operator + (Fraction a, Fraction b)
        {
            Fraction f = new Fraction(
                                        a.Numerator * b.Denominator + a.Denominator * b.Numerator,
                                        a.Denominator * b.Denominator);
            return f;
        }
        public static Fraction operator - (Fraction a, Fraction b)
        {
            Fraction f = new Fraction(
                                        a.Numerator * b.Denominator - a.Denominator * b.Numerator,
                                        a.Denominator * b.Denominator);
            return f;
        }
        public static Fraction operator * (Fraction a, Fraction b)
        {
            Fraction f = new Fraction(
                                        a.Numerator * b.Numerator,
                                        a.Denominator * b.Denominator);
            return f;
        }
        public static Fraction operator !(Fraction a)
        {           
            return new Fraction(a.Denominator, a.Numerator);
        }
        public static Fraction operator / (Fraction a, Fraction b)
        {
            Fraction f = a * (!b);
            return f;
        }
        public static implicit operator double(Fraction a)
        {
            
            return (double)a.Numerator / a.Denominator;
        }
        public static Fraction operator + (Fraction a, long b)
        {
            return new Fraction(a + new Fraction(b));
        }
        public static Fraction operator - (Fraction a, long b)
        {
            return new Fraction(a - new Fraction(b));
        }
        public static Fraction operator *(Fraction a, long b)
        {
            return new Fraction(a * new Fraction(b));
        }
        public static Fraction operator /(Fraction a, long b)
        {
            return new Fraction(a / new Fraction(b));
        }
        public static Fraction operator +(long b, Fraction a )
        {
            return new Fraction(a + new Fraction(b));
        }
        public static Fraction operator - (long b, Fraction a)
        {
            return new Fraction(-a + new Fraction(b));
        }
        public static Fraction operator *(long b, Fraction a)
        {
            return new Fraction(a * new Fraction(b));
        }
        public static Fraction operator /(long b, Fraction a)
        {
            return new Fraction( new Fraction(b)/a);
        }
        public static void simplify(Fraction a)
        {
            long nsd,numa=a.Numerator,dena=a.Denominator;
            while (numa != 0 && dena != 0)
            {
                if (numa > dena)
                    numa %= dena;
                else dena %= numa;
                
            }a.Numerator /= (dena + numa);
             a.Denominator /= (dena + numa);
        }
       
        public static bool operator < (Fraction a, Fraction b)
        {
            return (double)a < (double)b;
        }
        public static bool operator > (Fraction a, Fraction b)
        {
            return (double)a > (double)b;
        }
        public static bool operator == (Fraction a, Fraction b)
        {
            return (double)a == (double)b;
        }
        public static bool operator != (Fraction a, Fraction b)
        {
            return (double)a != (double)b;
        }
        public static bool operator <= (Fraction a, Fraction b)
        {
            return (double)a <= (double)b;
        }
        public static bool operator >= (Fraction a, Fraction b)
        {
            return (double)a >= (double)b;
        }
    }
}
