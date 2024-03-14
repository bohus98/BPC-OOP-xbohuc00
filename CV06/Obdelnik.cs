using System;

namespace CV06
{
    public class Obdelnik : Objekt2D
    {
        private double a;
        private double b;

        public Obdelnik(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override void Kresli()
        {
            Console.WriteLine($"Obdelnik (a = {a}, b = {b})");
        }

        public override double SpoctiPlochu()
        {
            return a * b;
        }
    }
}
