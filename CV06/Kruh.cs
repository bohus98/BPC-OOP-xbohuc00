using System;

namespace CV06
{
    public class Kruh : Objekt2D
    {
        private double polomer;

        public Kruh(double polomer)
        {
            this.polomer = polomer;
        }

        public override void Kresli()
        {
            Console.WriteLine($"Kruh (r = {polomer})");
        }

        public override double SpoctiPlochu()
        {
            return Math.PI * polomer * polomer;
        }
    }
}
