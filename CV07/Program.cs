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
            string[] texty = { "ahoj", "hello", "bonjour" };
            Kruh[] kruhy = { new Kruh(5), new Kruh(8), new Kruh(3) };
            Obdelnik[] obdelniky = { new Obdelnik(4, 6), new Obdelnik(3, 3) };
            Trojuhelnik[] trojuhelniky = { new Trojuhelnik(3, 4, 5), new Trojuhelnik(5, 12, 13) };
            Elipsa[] elipsy = { new Elipsa(3, 4), new Elipsa(5, 6) };
            Ctverec[] ctverce = { new Ctverec(5), new Ctverec(8) };
            Objekt2D[] objekty = { new Kruh(5), new Obdelnik(4, 6), new Kruh(8), new Elipsa(3, 4), new Trojuhelnik(3, 4, 5), new Ctverec(5) };

            // Zavolání generických metod Nejvetsi a Nejmensi na jednotlivá pole
            Console.WriteLine("Největší číslo: " + Extremy.Nejvetsi(cisla));
            Console.WriteLine("Nejmenší číslo: " + Extremy.Nejmensi(cisla));

            Console.WriteLine("Největší text: " + Extremy.Nejvetsi(texty));
            Console.WriteLine("Nejmenší text: " + Extremy.Nejmensi(texty));

            Console.WriteLine("Největší kruh: " + Extremy.Nejvetsi(kruhy).ToString());
            Console.WriteLine("Nejmenší obdélník: " + Extremy.Nejmensi(obdelniky).ToString());

            // Zavolání generických metod na pole Objekt2D[]
            Console.WriteLine("Největší objekt: " + Extremy.Nejvetsi(objekty).ToString());
            Console.WriteLine("Nejmenší objekt: " + Extremy.Nejmensi(objekty).ToString());

            // Zavolání generických metod na pole trojuhelniky[]
            Console.WriteLine("Největší trojúhelník: " + Extremy.Nejvetsi(trojuhelniky).ToString());
            Console.WriteLine("Nejmenší trojúhelník: " + Extremy.Nejmensi(trojuhelniky).ToString());

            // Zavolání generických metod na pole elipsy[]
            Console.WriteLine("Největší elipsa: " + Extremy.Nejvetsi(elipsy).ToString());
            Console.WriteLine("Nejmenší elipsa: " + Extremy.Nejmensi(elipsy).ToString());

            // Zavolání generických metod na pole ctverce[]
            Console.WriteLine("Největší čtverec: " + Extremy.Nejvetsi(ctverce).ToString());
            Console.WriteLine("Nejmenší čtverec: " + Extremy.Nejmensi(ctverce).ToString());

            // Použití LINQ pro filtrování hodnot v intervalu 4 až 8
            var filtrovaneCisla = cisla.Where(c => c >= 4 && c <= 8);

            // Výpis filtrovaných hodnot na konzoli
            Console.WriteLine("Filtrovaná čísla: " + string.Join(", ", filtrovaneCisla));
        }
    }
}
