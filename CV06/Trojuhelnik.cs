using System;

namespace CV06
{
    public class Trojuhelnik : Objekt2D
    {
        private double a;
        private double v;

        public Trojuhelnik(double a, double v)
        {
            this.a = a;
            this.v = v;
        }

        public override void Kresli()
        {
            Console.WriteLine($"Trojuhelnik (a = {a}, v = {v})");
        }

        public override double SpoctiPlochu()
        {
            // Implementace výpočtu plochy trojúhelníku
            // zde je pouze návrat hodnoty, opravte podle skutečného výpočtu
            return 0.0;
        }
    }
}
