using System;

namespace ComplexNumberApp
{
    public class Complex
    {
        public double Realna { get; private set; }
        public double Imaginarni { get; private set; }

        public Complex(double realna, double imaginarni)
        {
            Realna = realna;
            Imaginarni = imaginarni;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.Realna + c2.Realna, c1.Imaginarni + c2.Imaginarni);
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.Realna - c2.Realna, c1.Imaginarni - c2.Imaginarni);
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex(c1.Realna * c2.Realna - c1.Imaginarni * c2.Imaginarni, c1.Realna * c2.Imaginarni + c1.Imaginarni * c2.Realna);
        }

        public static Complex operator /(Complex c1, Complex c2)
        {
            double divisor = c2.Realna * c2.Realna + c2.Imaginarni * c2.Imaginarni;
            return new Complex((c1.Realna * c2.Realna + c1.Imaginarni * c2.Imaginarni) / divisor, (c1.Imaginarni * c2.Realna - c1.Realna * c2.Imaginarni) / divisor);
        }

        public static Complex operator -(Complex c)
        {
            return new Complex(-c.Realna, -c.Imaginarni);
        }

        public override string ToString()
        {
            return $"{Realna} + {Imaginarni}i";
        }

        public Complex Conjugate()
        {
            return new Complex(Realna, -Imaginarni);
        }

        public double Modulus()
        {
            return Math.Sqrt(Realna * Realna + Imaginarni * Imaginarni);
        }

        public double Argument()
        {
            return Math.Atan2(Imaginarni, Realna);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Complex))
                return false;

            Complex c = (Complex)obj;
            return Realna == c.Realna && Imaginarni == c.Imaginarni;
        }

        public override int GetHashCode()
        {
            return Realna.GetHashCode() ^ Imaginarni.GetHashCode();
        }

        public static bool operator ==(Complex c1, Complex c2)
        {
            return c1.Equals(c2);
        }

        public static bool operator !=(Complex c1, Complex c2)
        {
            return !c1.Equals(c2);
        }
    }
}
