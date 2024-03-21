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

        // Přetížené metody pro string s kulturově nezávislým porovnáním
        public static string Nejvetsi(string[] pole)
        {
            if (pole == null || pole.Length == 0)
                throw new ArgumentException("Pole je prázdné nebo null");

            string max = pole[0];
            foreach (string item in pole)
            {
                if (string.Compare(item, max, StringComparison.InvariantCulture) > 0)
                    max = item;
            }
            return max;
        }

        public static string Nejmensi(string[] pole)
        {
            if (pole == null || pole.Length == 0)
                throw new ArgumentException("Pole je prázdné nebo null");

            string min = pole[0];
            foreach (string item in pole)
            {
                if (string.Compare(item, min, StringComparison.InvariantCulture) < 0)
                    min = item;
            }
            return min;
        }
    }
}