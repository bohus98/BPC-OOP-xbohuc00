using System;

namespace ComplexNumberApp
{
    public class TestComplex
    {
        public static double Epsilon = 1E-6;

        public static void Test(Complex actual, Complex expected, string testName)
        {
            if (Math.Abs(actual.Realna - expected.Realna) < Epsilon && Math.Abs(actual.Imaginarni - expected.Imaginarni) < Epsilon)
                Console.WriteLine($"{testName}: OK");
            else
                Console.WriteLine($"{testName}: Chyba - Očekávaná hodnota: {expected}, Skutečná hodnota: {actual}");
        }

        public static void Test(double actual, double expected, string testName)
        {
            if (Math.Abs(actual - expected) < Epsilon)
                Console.WriteLine($"{testName}: OK");
            else
                Console.WriteLine($"{testName}: Chyba - Očekávaná hodnota: {expected}, Skutečná hodnota: {actual}");
        }
    }
}
