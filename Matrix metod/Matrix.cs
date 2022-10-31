using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_metod
{
    internal class Matrix
    {
        // Змінні класу
        private double det_A;
        private const int n = 3;
        private double[,] a = new double[n, n];// масив матриці
        private double[] b = new double[n];// масив правих коефіцієнтів рівняння
        public double[,] C = new double[n, n];
        public double[,] C_t = new double[n, n];
        public double[] x = new double[n];// масив відповідей
        //Конструктор класу
        public Matrix()
        {
            det_A = 0;
            for (int i = 0; i < n; i++)
            {
                b[i] = 0;
                x[i] = 0;
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = 0;
                    C[i, j] = 0;
                    C_t[i, j] = 0;
                }
            }
        }
        // Перевантаження конструктора класу
        public Matrix(double[,] a_, double[] b_)
        {
            for (int i = 0; i < n; i++)
            {
                b[i] = b_[i];
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = a_[i, j];
                }
            }
        }
        // Головний метод, в якому реалізований алгоритм вирішення СЛАР матричним  методом.
        public void Solve()
        {
            det_A = a[0, 0] * a[1, 1] * a[2, 2] + a[0, 1] * a[1, 2] * a[2, 0] + a[0, 2] * a[1, 0] * a[2, 1] - a[0, 2] * a[1, 1] * a[2, 0] - a[0, 0] * a[1, 2] * a[2, 1] - a[0, 1] * a[1, 0] * a[2, 2];
            C[0, 0] = (a[1, 1] * a[2, 2]) - (a[1, 2] * a[2, 1]);
            C[0, 1] = ((a[1, 0] * a[2, 2]) - (a[1, 2] * a[2, 0])) * (-1);
            C[0, 2] = (a[1, 0] * a[2, 1]) - (a[1, 1] * a[2, 0]);
            C[1, 0] = ((a[0, 1] * a[2, 2]) -(a[0, 2] * a[2, 1])) * (-1);
            C[1, 1] = (a[0, 0] * a[2, 2]) - (a[0, 2] * a[2, 0]) ;
            C[1, 2] = ((a[0, 0] * a[2, 1]) -(a[0, 1] * a[2, 0])) * (-1);
            C[2, 0] = (a[0, 1] * a[1, 2]) - (a[0, 2] * a[1, 1]);
            C[2, 1] = ((a[0, 0] * a[1, 2]) -(a[0, 2] * a[1, 0])) * (-1);
            C[2, 2] = (a[0, 0] * a[1, 1]) - (a[0, 1] * a[1, 0]);
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    C_t[i, j] = C[j, i];
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    C[i, j] = C_t[i, j]/det_A;
                }
            }
            for(int i = 0; i < n; i++)
            {
                x[i] = (C[i, 0] * b[0]) + (C[i, 1] * b[1]) + (C[i, 2] * b[2]);
            }
        }

    }
}
