﻿using System;

namespace cv04
{
    class Program
    {
        static void Main(string[] args)
        {
            string testText = "Toto je retezec predstavovany nekolika radky,\n"
                             + "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
                             + "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
                             + "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
                             + "posledni veta!";

            StringStatistics s = new StringStatistics(testText);
            Console.WriteLine("Pocet slov: {0}", s.NumberOfWords());
            Console.WriteLine("Pocet riadkov: {0}", s.NumberOfLines());
            Console.WriteLine("Pocet viet: {0}", s.NumberOfSentences());
            Console.WriteLine("Najdlhsie slovo: {0}", string.Join(", ", s.LongestWords()));
            Console.WriteLine("Najkradsie slovo: {0}", string.Join(", ", s.ShortestWords()));
            Console.WriteLine("Najcastejsie slova: {0}", string.Join(", ", s.MostCommonWord()));
            Console.WriteLine("Zoradene slova: {0}", string.Join(", ", s.AlphabeticallySortedWords()));
            Console.ReadLine();
        }
    }
}
