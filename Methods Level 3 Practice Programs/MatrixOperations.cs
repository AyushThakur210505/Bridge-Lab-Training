using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_3_Practice_Programs
{
    internal class MatrixOperations
    {
        public static void display()
        {
            Console.Write("Enter number of rows : ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns : ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix1 = CreateRandomMatrix(rows, cols);
            int[,] matrix2 = CreateRandomMatrix(rows, cols);

            Console.WriteLine("\nMatrix 1");
            DisplayMatrix(matrix1);

            Console.WriteLine("\nMatrix 2");
            DisplayMatrix(matrix2);

            Console.WriteLine("\nAddition");
            DisplayMatrix(AddMatrix(matrix1, matrix2));

            Console.WriteLine("\nSubtraction");
            DisplayMatrix(SubtractMatrix(matrix1, matrix2));

            if (rows == cols)
            {
                Console.WriteLine("\nMultiplication");
                DisplayMatrix(MultiplyMatrix(matrix1, matrix2));

                Console.WriteLine("\nTranspose of Matrix 1");
                DisplayMatrix(Transpose(matrix1));

                if (rows == 2)
                {
                    Console.WriteLine("\nDeterminant : " + Determinant2x2(matrix1));

                    Console.WriteLine("\nInverse");
                    DisplayDoubleMatrix(Inverse2x2(matrix1));
                }
                else if (rows == 3)
                {
                    Console.WriteLine("\nDeterminant : " + Determinant3x3(matrix1));
                }
            }
            else
            {
                Console.WriteLine("\nMultiplication, Determinant and Inverse require square matrices.");
            }
        }

        public static int[,] CreateRandomMatrix(int rows, int cols)
        {
            Random random = new Random();
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                }
            }

            return matrix;
        }

        public static int[,] AddMatrix(int[,] a, int[,] b)
        {
            int rows = a.GetLength(0);
            int cols = a.GetLength(1);

            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[i, j] = a[i, j] + b[i, j];

            return result;
        }

        public static int[,] SubtractMatrix(int[,] a, int[,] b)
        {
            int rows = a.GetLength(0);
            int cols = a.GetLength(1);

            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[i, j] = a[i, j] - b[i, j];

            return result;
        }

        public static int[,] MultiplyMatrix(int[,] a, int[,] b)
        {
            int n = a.GetLength(0);

            int[,] result = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        result[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            return result;
        }

        public static int[,] Transpose(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] transpose = new int[cols, rows];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    transpose[j, i] = matrix[i, j];

            return transpose;
        }

        public static int Determinant2x2(int[,] matrix)
        {
            return (matrix[0, 0] * matrix[1, 1]) -
                   (matrix[0, 1] * matrix[1, 0]);
        }

        public static int Determinant3x3(int[,] matrix)
        {
            return matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])
                 - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0])
                 + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
        }

        public static double[,] Inverse2x2(int[,] matrix)
        {
            int determinant = Determinant2x2(matrix);

            double[,] inverse = new double[2, 2];

            if (determinant == 0)
                return inverse;

            inverse[0, 0] = matrix[1, 1] / (double)determinant;
            inverse[0, 1] = -matrix[0, 1] / (double)determinant;
            inverse[1, 0] = -matrix[1, 0] / (double)determinant;
            inverse[1, 1] = matrix[0, 0] / (double)determinant;

            return inverse;
        }

        public static void DisplayMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static void DisplayDoubleMatrix(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j].ToString("F2") + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
