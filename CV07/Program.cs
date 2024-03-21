using System;
using System.Linq;

namespace CV07
{
    class Program
    {
        static void Main(string[] args)
        {
             // Vstupní pole int[]
            int[] cisla = { 1, 3, 5, 7, 9 };

            // Naplnění různých polí
            string[] texty = { "jablko", "hruska", "banan", "kiwi", "pomaranc", "sadafgasdasfgasdgllllsadlklkg" };
            Kruh[] kruhy = { new Kruh(5), new Kruh(8), new Kruh(3) };
            Obdelnik[] obdelniky = { new Obdelnik(1 , 2), new Obdelnik(25, 2), new Obdelnik(1, 6) };
            Trojuhelnik[] trojuhelniky = { new Trojuhelnik(3, 4, 5), new Trojuhelnik(5, 12, 13), new Trojuhelnik(7, 8, 9) };
            Elipsa[] elipsy = { new Elipsa(3, 4), new Elipsa(5, 6), new Elipsa(5, 3) };
            Ctverec[] ctverce = { new Ctverec(3), new Ctverec(5), new Ctverec(8) };
            //Objekt2D[] objekty = { new Kruh(5), new Obdelnik(4, 6), new Kruh(8), new Elipsa(3, 4), new Trojuhelnik(3, 4, 5), new Ctverec(5) };

            // Zavolání generických metod Nejvetsi a Nejmensi na jednotlivá pole
            Console.WriteLine("Nejvacsie cislo: " + Extremy.Nejvetsi(cisla));
            Console.WriteLine("Nejmensie cislo: " + Extremy.Nejmensi(cisla));

            Console.WriteLine("Nejvacsi text: " + Extremy.Nejvetsi(texty));
            Console.WriteLine("Nejmensi text: " + Extremy.NajkratsiString(texty));

            Console.WriteLine("Nejvacsi kruh: " + Extremy.Nejvetsi(kruhy).ToString());
            Console.WriteLine("Nejmensi obdlznik: " + Extremy.Nejmensi(obdelniky).ToString());

            //// Zavolání generických metod na pole Objekt2D[]
            //Console.WriteLine("Nejvacsi objekt: " + Extremy.Nejvetsi(objekty).ToString());
            //Console.WriteLine("Nejmensi objekt: " + Extremy.Nejmensi(objekty).ToString());

            // Zavolání generických metod na pole trojuhelniky[]
            Console.WriteLine("Nejvacsi trojuholnik: " + Extremy.Nejvetsi(trojuhelniky).ToString());
            Console.WriteLine("Nejmensi trojuholnik: " + Extremy.Nejmensi(trojuhelniky).ToString());

            // Zavolání generických metod na pole elipsy[]
            Console.WriteLine("Nejvacsia elipsa: " + Extremy.Nejvetsi(elipsy).ToString());
            Console.WriteLine("Nejmensia elipsa: " + Extremy.Nejmensi(elipsy).ToString());

            // Zavolání generických metod na pole ctverce[]
            Console.WriteLine("Nejvacsi stvorec: " + Extremy.Nejvetsi(ctverce).ToString());
            Console.WriteLine("Nejmensi stvorec: " + Extremy.Nejmensi(ctverce).ToString());

            // Použití LINQ pro filtrování hodnot v intervalu 4 až 8
            var filtrovaneCisla = cisla.Where(c => c >= 4 && c <= 8);

            // Výpis filtrovaných hodnot na konzoli
            Console.WriteLine("Filtrovane cisla: " + string.Join(", ", filtrovaneCisla));
        }
    }
}
