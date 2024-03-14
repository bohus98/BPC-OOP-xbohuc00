using System;

namespace CV06
{
    public class PravouhlyKvadr : Objekt3D
    {
        private double a; // délka hrany
        private double b; // délka druhé hrany
        private double c; // délka třetí hrany

        public PravouhlyKvadr(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override void Kresli()
        {
            Console.WriteLine($"PravouhlyKvadr (a = {a}, b = {b}, c = {c})");
        }

        public override double SpoctiPovrch()
        {
            return 2 * (a * b + a * c + b * c); // plocha
        }

        public override double SpoctiObjem()
        {
            return a * b * c; // objem
        }
    }
}
