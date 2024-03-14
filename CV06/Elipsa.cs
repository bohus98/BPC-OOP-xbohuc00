using System;

namespace CV06
{
    public class Elipsa : Objekt2D
    {
        private double poloosaA;
        private double poloosaB;

        public Elipsa(double poloosaA, double poloosaB)
        {
            this.poloosaA = poloosaA;
            this.poloosaB = poloosaB;
        }

        public override void Kresli()
        {
            Console.WriteLine($"Elipsa (a = {poloosaA}, b = {poloosaB})");
        }

        public override double SpoctiPlochu()
        {
            return Math.PI * poloosaA * poloosaB;
        }
    }
}
