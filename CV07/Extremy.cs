using System;
using System.Linq;

namespace CV07
{
    public class Extremy
    {
        public static T Nejvetsi<T>(T[] pole) where T : IComparable
        {
            if (pole == null || pole.Length == 0)
                throw new ArgumentException("Pole je prázdné nebo null");

            T max = pole[0];
            foreach (T item in pole)
            {
                if (item.CompareTo(max) > 0)
                    max = item;
            }
            return max;
        }

        public static T Nejmensi<T>(T[] pole) where T : IComparable
        {
            if (pole == null || pole.Length == 0)
                throw new ArgumentException("Pole je prázdné nebo null");

            T min = pole[0];
            foreach (T item in pole)
            {
                if (item.CompareTo(min) < 0)
                    min = item;
            }
            return min;
        }

        public static string NajkratsiString(string[] pole)
        {
            if (pole == null || pole.Length == 0)
            {
                throw new ArgumentException("Pole je prázdné nebo null");
            }

            string NajkratsiString = pole[0];
            foreach (string retazec in pole)
            {
                if (string.Length < NajkratsiString.Length)
                {
                    NajkratsiString = retazec;
                }
                
            }
            return NajkratsiString;

        }
    }
}
