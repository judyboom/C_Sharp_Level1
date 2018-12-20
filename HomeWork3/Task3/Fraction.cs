using System;

namespace Task3
{
    class Fraction
    {
        int Num;
        int Denom;

        public Fraction(int num, int denom)
        {
            Num = num;
            if (denom == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен 0");
            }
            else Denom = denom;
        }

        public Fraction Sum(Fraction fraction)
        {
            var num = Num * fraction.Denom + fraction.Num * Denom;
            var denom = Denom * fraction.Denom;
            Fraction result = new Fraction(num, denom);
            return result.Simplify();
        }

        public Fraction Minus(Fraction fraction)
        {
            var num = Num * fraction.Denom - fraction.Num * Denom;
            var denom = Denom * fraction.Denom;
            Fraction result = new Fraction(num, denom);
            return result.Simplify();
        }

        public Fraction Multy(Fraction fraction)
        {
            var num = Num * fraction.Num;
            var denom = Denom * fraction.Denom;
            Fraction result = new Fraction(num, denom);
            return result.Simplify();
        }

        public Fraction Div(Fraction fraction)
        {
            return Multy(fraction.Reverse());
        }

        public Fraction Reverse()
        {
            return new Fraction(Denom, Num);
        }

        public Fraction Simplify()
        {
            int nod = NOD(Num, Denom);
            Num /= nod;
            Denom /= nod;
            return this;
        }

        static int NOD(int a, int b)
        {
            while (a != b)
                if (a > b) a = a - b; else b = b - a;
            return a;
        }

        public override string ToString()
        {
            return Num  + ((Denom == 1) ? "": "/" + Denom.ToString());
        }

    }
}
