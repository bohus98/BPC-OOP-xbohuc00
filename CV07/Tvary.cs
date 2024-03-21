using System;

namespace CV07
{
    public class Kruh : Objekt2D
    {
        public double Radius { get; set; }

        public Kruh(double radius)
        {
            Radius = radius;
        }

        public override double Plocha()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return $"Kruh s poloměrem {Radius}, plocha: {Plocha()}";
        }
    }

    public class Obdelnik : Objekt2D
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Obdelnik(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double Plocha()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return $"Obdélník s rozměry {Width}x{Height}, plocha: {Plocha()}";
        }
    }

     public class Elipsa : Objekt2D
    {
        public double PolooseA { get; set; }
        public double PolooseB { get; set; }

        public Elipsa(double polooseA, double polooseB)
        {
            PolooseA = polooseA;
            PolooseB = polooseB;
        }

        public override double Plocha()
        {
            return Math.PI * PolooseA * PolooseB;
        }

        public override string ToString()
        {
            return $"Elipsa s poloosami {PolooseA} a {PolooseB}, plocha: {Plocha()}";
        }
    }

    public class Trojuhelnik : Objekt2D
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Trojuhelnik(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double Plocha()
        {
            double s = (A + B + C) / 2;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }

        public override string ToString()
        {
            return $"Trojúhelník se stranami {A}, {B} a {C}, plocha: {Plocha()}";
        }
    }

    public class Ctverec : Objekt2D
    {
        public double Strana { get; set; }

        public Ctverec(double strana)
        {
            Strana = strana;
        }

        public override double Plocha()
        {
            return Strana * Strana;
        }

        public override string ToString()
        {
            return $"Čtverec se stranou {Strana}, plocha: {Plocha()}";
        }
    }
}
