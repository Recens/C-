using System;
using System.Diagnostics.CodeAnalysis;

namespace LB1
{
    class Matrix
    {
        public int size;
        public double[,] mat;



        public Matrix(int size)
        {
            this.size = size;
            mat = new double[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    mat[i, j] = double.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }

                Console.WriteLine();
            }

        }

        public void Sum()
        {
            double sum = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j += 2)
                {
                    sum = sum + mat[i, j];
                }

            }

            Console.Write("Сумма строк = ");
            Console.Write(sum);
            Console.Write("\n");
        }

        public void multiplication_scalar(int x)
        {
            Double[,] temp;
            temp = new double[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    temp[i, j] = mat[i, j] * x;
                }

            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(temp[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        public bool Stochasticity()
        {
            bool point = false;
            double row = 0;
            double col = 0;
            double rows = 0;
            double cols = 0;
            for (int i = 0; i < size; i++)
            {
                row = 0;
                for (int j = 0; j < size; j++)
                {
                    row = row + mat[i, j];

                }

                if (row == 1)
                {
                    rows++;
                }
            }
            Console.WriteLine(row);
            for (int j = 0; j < size; j++)
            {
                col = 0;
                for (int i = 0; i < size; i++)
                {
                    col += mat[i, j];

                }

                if (col == 1)
                {
                    cols++;
                }
                
            }
            Console.WriteLine(col);
            if (rows==size && cols==size)
            {
                return true;
            }
            return false;
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {

            Matrix rt = new Matrix(3);
            rt.Sum();
            rt.multiplication_scalar(2);
            
            Console.WriteLine(rt.Stochasticity());



        }
    }
}
