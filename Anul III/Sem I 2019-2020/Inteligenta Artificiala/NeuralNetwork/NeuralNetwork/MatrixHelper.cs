﻿namespace NeuralNetwork
{
    public class MatrixHelper
    {
        public Matrix MatrixMultiplication(Matrix a, Matrix b)
        {
            Matrix c = new Matrix(a.GetLength(0), b.GetLength(1));

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    double value = 0;
                    for (int q = 0; q < a.GetLength(1); q++)
                    {
                        value += a[i, q] * b[q, j];
                    }
                    c[i, j] = value;
                }
            }

            return c;
        }

        public Matrix Substraction(Matrix a, Matrix b)
        {
            Matrix c = new Matrix(a.GetLength(0), a.GetLength(1));

            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    c[i, j] = a[i, j] - b[i, j];
                }
            }

            return c;
        }

        public Matrix Divide(Matrix a, double b)
        {
            Matrix c = new Matrix(a.GetLength(0), a.GetLength(1));

            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    c[i, j] = a[i, j] / b;
                }

            return c;
        }

        public Matrix Transpose(double[,] a)
        {
            Matrix toReturn = new Matrix(a.GetLength(1), a.GetLength(0));
            for (int i = 0; i < a.GetLength(1); i++)
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    toReturn[i, j] = a[j, i];
                }
            return toReturn;
        }
    }
}
