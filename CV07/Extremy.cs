using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV07
{
    public static class Extremy
    {
        // Statická metoda pro nalezení největšího prvku v poli
        public static T Nejvetsi<T>(T[] pole) where T : IComparable
        {
            if (pole == null || pole.Length == 0)
            {
                throw new ArgumentException("Pole nemůže být null nebo prázdné.");
            }

            T nejvetsi = pole[0];
            foreach (T prvek in pole)
            {
                if (prvek.CompareTo(nejvetsi) > 0)
                {
                    nejvetsi = prvek;
                }
            }
            return nejvetsi;
        }

        // Statická metoda pro nalezení nejmenšího prvku v poli
        public static T Nejmensi<T>(T[] pole) where T : IComparable
        {
            if (pole == null || pole.Length == 0)
            {
                throw new ArgumentException("Pole nemůže být null nebo prázdné.");
            }

            T nejmensi = pole[0];
            foreach (T prvek in pole)
            {
                if (prvek.CompareTo(nejmensi) < 0)
                {
                    nejmensi = prvek;
                }
            }
            return nejmensi;
        }

        // Statická metoda pro nalezení nejdelšího řetězce v poli
        public static string NejdelsiRetazec(string[] pole)
        {
            if (pole == null || pole.Length == 0)
            {
                throw new ArgumentException("Pole řetězců nemůže být null nebo prázdné.");
            }

            string nejdelsiRetazec = pole[0];
            foreach (string retazec in pole)
            {
                if (retazec.Length > nejdelsiRetazec.Length)
                {
                    nejdelsiRetazec = retazec;
                }
            }
            return nejdelsiRetazec;
        }

        // Statická metoda pro nalezení nejkratšího řetězce v poli
        public static string NejkratsiRetazec(string[] pole)
        {
            if (pole == null || pole.Length == 0)
            {
                throw new ArgumentException("Pole řetězců nemůže být null nebo prázdné.");
            }

            string nejkratsiRetazec = pole[0];
            foreach (string retazec in pole)
            {
                if (retazec.Length < nejkratsiRetazec.Length)
                {
                    nejkratsiRetazec = retazec;
                }
            }
            return nejkratsiRetazec;
        }
    }
}