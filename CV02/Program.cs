using System;

namespace ComplexNumberApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // TestComplex pro operátory
            Complex a = new Complex(3, 4);
            Complex b = new Complex(2, -5);
            TestComplex.Test(a + b, new Complex(5, -1), "Operátor +");
            TestComplex.Test(a - b, new Complex(1, 9), "Operátor -");
            TestComplex.Test(a * b, new Complex(26, -7), "Operátor *");
            TestComplex.Test(a / b, new Complex(7, 8), "Operátor /");
            TestComplex.Test(-a, new Complex(-3, -4), "Unární operátor -");

            // TestComplex pro metody
            TestComplex.Test(a.Conjugate(), new Complex(3, -4), "Metoda Conjugate");
            TestComplex.Test(b.Conjugate(), new Complex(2, 5), "Metoda Conjugate");

         

            // Test operátorů == a !=
            Console.WriteLine($"a == b ? {a == b}");
            Console.WriteLine($"a != b ? {a != b}");
        }
    }
}
