using System;

namespace CV06
{
    public class Valec : Objekt3D
    {
        private double polomer;
        private double vyska;

        public Valec(double polomer, double vyska)
        {
            this.polomer = polomer;
            this.vyska = vyska;
        }

        public override void Kresli()
        {
            Console.WriteLine($"Valec (r = {polomer}, v = {vyska})");
        }

        public override double SpoctiPovrch()
        {
            return 2 * Math.PI * polomer * (polomer + vyska);
        }

        public override double SpoctiObjem()
        {
            return Math.PI * polomer * polomer * vyska;
        }
    }
}
