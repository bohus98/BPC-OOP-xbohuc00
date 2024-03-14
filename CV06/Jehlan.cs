using System;

namespace CV06
{
    public class Jehlan : Objekt3D
    {
        private double a; // délka hrany
        private double v; // výška

        public Jehlan(double a, double v)
        {
            this.a = a;
            this.v = v;
        }

        public override void Kresli()
        {
            Console.WriteLine($"Jehlan (a = {a}, v = {v})");
        }

        public override double SpoctiPovrch()
        {
            double s = Math.Sqrt(a * a + v * v / 4); // délka strany
            return a * a + 2 * a * s; // plocha
        }

        public override double SpoctiObjem()
        {
            return (1.0 / 3.0) * a * a * v;
        }
    }
}
