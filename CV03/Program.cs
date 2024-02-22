using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] values1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        double[,] values2 = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
        Matrix m1 = new Matrix(values1);
        Matrix m2 = new Matrix(values2);

        Console.WriteLine("Matrix 1:");
        Console.WriteLine(m1);

        Console.WriteLine("Matrix 2:");
        Console.WriteLine(m2);

        Console.WriteLine("Matrix 1 + Matrix 2:");
        Console.WriteLine(m1 + m2);

        Console.WriteLine("Matrix 1 - Matrix 2:");
        Console.WriteLine(m1 - m2);

        Console.WriteLine("Matrix 1 * Matrix 2:");
        Console.WriteLine(m1 * m2);

        Console.WriteLine("Determinant of Matrix 1: " + m1.Determinant());
        Console.WriteLine("Determinant of Matrix 2: " + m2.Determinant());
    }
}
