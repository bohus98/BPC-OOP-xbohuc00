using System;

namespace CV07
{
    public abstract class Objekt2D : IComparable
    {
        public abstract double Plocha();

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Objekt2D other = obj as Objekt2D;
            if (other != null)
                return this.Plocha().CompareTo(other.Plocha());
            else
                throw new ArgumentException("Object is not a Objekt2D");
        }
    }
}
