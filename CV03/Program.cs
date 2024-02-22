using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] values1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        double[,] values2 = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
        double[,] values3 = { { 9, 8 }, { 6, 5 } };
        double[,] values4 = { { 1, 2 }, { 4, 5 } };
        double[,] values5 = { { 1, 2, 3, 4 }, { 4, 5, 6, 7 }, { 7, 8, 9, 0 } };
        double[,] values6 = { { 1, 2, 3, 4 }, { 4, 5, 6, 7 }, { 7, 8, 9, 0 }, { 1, 2, 3, 4 } };
        double[,] values7 = { { 4 } };
        Matrix m1 = new Matrix(values1);
        Matrix m2 = new Matrix(values2);
        Matrix m3 = new Matrix(values3);
        Matrix m4 = new Matrix(values4);
        Matrix m5 = new Matrix(values5);
        Matrix m6 = new Matrix(values6);
        Matrix m7 = new Matrix(values7);

        Console.WriteLine("Matica 1:");
        Console.WriteLine(m1);

        Console.WriteLine("Matica 2:");
        Console.WriteLine(m2);

        Console.WriteLine("Matica 3:");
        Console.WriteLine(m3);

        Console.WriteLine("Matica 4:");
        Console.WriteLine(m4);

        Console.WriteLine("Matica 5:");
        Console.WriteLine(m5);

        Console.WriteLine("Matica 6:");
        Console.WriteLine(m6);

        Console.WriteLine("Matica 7:");
        Console.WriteLine(m7);

        Console.WriteLine("Matica 1 + Matica 2:");
        Console.WriteLine(m1 + m2);

        Console.WriteLine("Matica 1 - Matica 2:");
        Console.WriteLine(m1 - m2);

        Console.WriteLine("Matica 1 * Matica 2:");
        Console.WriteLine(m1 * m2);

        Console.WriteLine("Matica 3 + Matica 4:");
        Console.WriteLine(m3 + m4);

        Console.WriteLine("Matica 3 - Matica 4:");
        Console.WriteLine(m3 - m4);

        Console.WriteLine("Matica 3 * Matica 4:");
        Console.WriteLine(m6 * m6);

        //Console.WriteLine("Matica 1 + Matica 4:");
        //Console.WriteLine(m1 + m4);

        //Console.WriteLine("Matica 1 - Matica 4:");
        //Console.WriteLine(m1 - m4);

        //Console.WriteLine("Matica 1 * Matica 4:");
        //Console.WriteLine(m1 * m4);

        Console.WriteLine("Determinant Matice 1: " + m1.Determinant());
        Console.WriteLine("Determinant Matice 2: " + m2.Determinant());
        Console.WriteLine("Determinant Matice 2: " + m3.Determinant());
        Console.WriteLine("Determinant Matice 7: " + m7.Determinant());

        Console.WriteLine("Matica 1 != Matica 2:");
        Console.WriteLine(m1 != m2);
        Console.WriteLine("Matica 1 == Matica 2:");
        Console.WriteLine(m1 == m2);
        //Console.WriteLine("Determinant Matice 5: " + m5.Determinant());
        //Console.WriteLine("Determinant Matice 6: " + m6.Determinant());
    }
}
