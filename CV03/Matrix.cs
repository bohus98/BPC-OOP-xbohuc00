using System;

public class Matrix
{
    private double[,] data;

    public Matrix(double[,] values)
    {
        data = values;
    }

    public static Matrix operator +(Matrix m1, Matrix m2)
    {
        if (m1.data.GetLength(0) != m2.data.GetLength(0) || m1.data.GetLength(1) != m2.data.GetLength(1))
            throw new ArgumentException("Matice musia mat rovnaku velkost pre scitanie.");

        double[,] result = new double[m1.data.GetLength(0), m1.data.GetLength(1)];

        for (int i = 0; i < m1.data.GetLength(0); i++)
        {
            for (int j = 0; j < m1.data.GetLength(1); j++)
            {
                result[i, j] = m1.data[i, j] + m2.data[i, j];
            }
        }

        return new Matrix(result);
    }

    public static Matrix operator -(Matrix m1, Matrix m2)
    {
        if (m1.data.GetLength(0) != m2.data.GetLength(0) || m1.data.GetLength(1) != m2.data.GetLength(1))
            throw new ArgumentException("Matice musia mat rovnaku velkost pre odscitanie.");

        double[,] result = new double[m1.data.GetLength(0), m1.data.GetLength(1)];

        for (int i = 0; i < m1.data.GetLength(0); i++)
        {
            for (int j = 0; j < m1.data.GetLength(1); j++)
            {
                result[i, j] = m1.data[i, j] - m2.data[i, j];
            }
        }

        return new Matrix(result);
    }

    public static Matrix operator *(Matrix m1, Matrix m2)
    {
        if (m1.data.GetLength(1) != m2.data.GetLength(0))
            throw new ArgumentException("Pocet stlpcov v prvej matici musi byt rovanky ako pocet riadkov v druhej matici pre nasobenie.");

        double[,] result = new double[m1.data.GetLength(0), m2.data.GetLength(1)];

        for (int i = 0; i < m1.data.GetLength(0); i++)
        {
            for (int j = 0; j < m2.data.GetLength(1); j++)
            {
                for (int k = 0; k < m1.data.GetLength(1); k++)
                {
                    result[i, j] += m1.data[i, k] * m2.data[k, j];
                }
            }
        }

        return new Matrix(result);
    }

    public static bool operator ==(Matrix m1, Matrix m2)
    {
        if (ReferenceEquals(m1, null))
            return ReferenceEquals(m2, null);
        if (ReferenceEquals(m2, null))
            return false;

        if (m1.data.GetLength(0) != m2.data.GetLength(0) || m1.data.GetLength(1) != m2.data.GetLength(1))
            return false;

        for (int i = 0; i < m1.data.GetLength(0); i++)
        {
            for (int j = 0; j < m1.data.GetLength(1); j++)
            {
                if (m1.data[i, j] != m2.data[i, j])
                    return false;
            }
        }

        return true;
    }

    public static bool operator !=(Matrix m1, Matrix m2)
    {
        return !(m1 == m2);
    }

    public static Matrix operator -(Matrix m)
    {
        double[,] result = new double[m.data.GetLength(0), m.data.GetLength(1)];

        for (int i = 0; i < m.data.GetLength(0); i++)
        {
            for (int j = 0; j < m.data.GetLength(1); j++)
            {
                result[i, j] = -m.data[i, j];
            }
        }

        return new Matrix(result);
    }

    public override string ToString()
    {
        string result = "";

        for (int i = 0; i < data.GetLength(0); i++)
        {
            for (int j = 0; j < data.GetLength(1); j++)
            {
                result += data[i, j] + " ";
            }
            result += "\n";
        }

        return result;
    }

    public double Determinant()
    {
        if (data.GetLength(0) != data.GetLength(1))
            throw new InvalidOperationException("Matice musia byt stvorcove pre vypocet determinantu.");
        if (data.GetLength(0) > 3)
            throw new InvalidOperationException("Vypocet determinantu je mozne pre matice s maximalnou velkostou 3x3.");

        if (data.GetLength(0) == 1)
        {
            return data[0, 0];
        }
        else if (data.GetLength(0) == 2)
        {
            return data[0, 0] * data[1, 1] - data[0, 1] * data[1, 0];
        }
        else // 3x3 matrix
        {
            return data[0, 0] * data[1, 1] * data[2, 2] +
                   data[0, 1] * data[1, 2] * data[2, 0] +
                   data[0, 2] * data[1, 0] * data[2, 1] -
                   data[0, 2] * data[1, 1] * data[2, 0] -
                   data[0, 1] * data[1, 0] * data[2, 2] -
                   data[0, 0] * data[1, 2] * data[2, 1];
        }
    }
}
