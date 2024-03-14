using System;

namespace CV06
{
    public class Koule : Objekt3D
    {
        private double polomer;

        public Koule(double polomer)
        {
            this.polomer = polomer;
        }

        public override void Kresli()
        {
            Console.WriteLine($"Koule (r = {polomer})");
        }

        public override double SpoctiPovrch()
        {
            return 4 * Math.PI * polomer * polomer;
        }

        public override double SpoctiObjem()
        {
            return (4.0 / 3.0) * Math.PI * polomer * polomer * polomer;
        }
    }
}
