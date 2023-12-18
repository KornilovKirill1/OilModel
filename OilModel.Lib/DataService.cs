using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Integration;
using Accord.Math.Integration;

namespace OilModel.Lib
{
    public class DataService
    {
        public int[] ZHoles(int N)
        {
            int[] matrixZ = new int[N];

            for (int i = 0; i < N; i++)
            {
                matrixZ[i] = 5;
            }
            return matrixZ;
        }

        public int[] XHoles(int N, int L)
        {
            int[] matrixX = new int[N];
            int value = 0;

            for (int i = N / L; i <= L; i++)
            {
                matrixX[i - 1] = value;
                value++;
            }
            return matrixX;
        }

        public double[,] barrelP(double plateP, double bottomholeP, int N)
        {
            double[,] matrixBarrelP = new double[1, N];
            double convertToPascalPlateP = plateP * Math.Pow(10.0, 6);
            double convertToPascalBottomholeP = /*Math.Round(bottomholeP * 0.10133)*/bottomholeP * Math.Pow(10.0, 6);

            for (int i = 0; i < N; i++)
            {
                matrixBarrelP[0, i] = convertToPascalPlateP - convertToPascalBottomholeP;
            }
            return matrixBarrelP;
        }

        public double flowRateBorisov(double Kh, double Kv, int h, double plateP, double bottomholeP, double M, int Rk, int L, double Rc)
        {
            double numerator = 2 * Math.PI * Keq(Kh, Kv) * Convert.ToDouble(h) * (plateP * Math.Pow(10.0, 6) - Math.Round(bottomholeP * 0.10133) * Math.Pow(10.0, 6)) * 86400.0;

            double denominator = M * (Math.Log((4.0 * Convert.ToDouble(Rk)) / L) + (Convert.ToDouble(h) / Convert.ToDouble(L)) * Math.Log(h / (2.0 * Math.PI * Rc)));

            double flowRate = numerator / denominator;

            return Math.Round(flowRate, 6);
        }

        public double[,] unknownСoefficients(int N, int L, double M, double Kh, double Kv, int h, double Rc, double Rk)
        {
            double[,] matrixUnknownCoeff = new double[N, N];
            int[] matrixZ = ZHoles(N);
            int[] matrixX = XHoles(N, L);
            //double result = 0;
            //double integral = 0;
            //double composite;

            //Console.WriteLine(matrixZ[0]);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    for (int n = -100; n <= 100; n++)
                    {
                        double f(double x) => Math.Pow(Math.Sqrt(Xh(Kh, Kv) * Math.Pow((matrixX[i] - (L / (2 * N))) - x, 2) + Xh(Kh, Kv) * Math.Pow(Rc, 2) + Xv(Kh, Kv) * Math.Pow(matrixZ[i] - matrixZ[j] + 2 * n * h, 2)), -1) +
                            Math.Pow(Math.Sqrt(Xh(Kh, Kv) * Math.Pow((matrixX[i] - (L / (2 * N))) - x, 2) + Xh(Kh, Kv) * Math.Pow(Rc, 2) + Xv(Kh, Kv) * Math.Pow(matrixZ[i] + matrixZ[j] + 2 * n * h, 2)), -1) -
                            Math.Pow(Math.Sqrt(Math.Pow(Xh(Kh, Kv) * Rk, 2) + Xv(Kh, Kv) * Math.Pow(matrixZ[i] - matrixZ[j] + 2 * n * h, 2)), -1) - Math.Pow(Math.Sqrt(Math.Pow(Xh(Kh, Kv) * Rk, 2) + Xv(Kh, Kv) * Math.Pow(matrixZ[i] + matrixZ[j] + 2 * n * h, 2)), -1);
                        //composite = GaussLegendreRule.Integrate(f, Convert.ToDouble(matrixX[j] + 1), Convert.ToDouble(matrixX[j]), N);

                        RombergMethod rm = new RombergMethod();
                        double result = RombergMethod.Integrate(f, Convert.ToDouble(matrixX[j] + 1), Convert.ToDouble(matrixX[j]));

                        matrixUnknownCoeff[i, j] = (M / (4 * Math.PI * Keq(Kh, Kv))) * Math.Pow(L / N, -1) * result;
                    }
                }
            }

            return matrixUnknownCoeff;
        }

        public double[,] extendedArray(double[,] matrixUnknownCoeff, double[,] matrixBarrelP, int N)
        {
            double[,] extendedArray = new double[N, N + 1];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    extendedArray[i, j] = matrixUnknownCoeff[i, j];
                }
            }
            for (int i = 0; i < N; i++)
            {
                extendedArray[i, N] = matrixBarrelP[0, i];
            }
            return extendedArray;
        }
        public double[] Gauss(double[,] Matrix)
        {
            int n = Matrix.GetLength(0); //Размерность начальной матрицы (строки)
            double[,] Matrix_Clone = new double[n, n + 1]; //Матрица-дублер
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n + 1; j++)
                    Matrix_Clone[i, j] = Matrix[i, j];

            // Прямой ход (Зануление нижнего левого угла)
            for (int k = 0; k < n; k++) //k-номер строки
            {
                for (int i = 0; i < n + 1; i++) //i-номер столбца
                    Matrix_Clone[k, i] = Matrix_Clone[k, i] / Matrix[k, k]; //Деление k-строки на первый член !=0 для преобразования его в единицу
                for (int i = k + 1; i < n; i++) //i-номер следующей строки после k
                {
                    double K = Matrix_Clone[i, k] / Matrix_Clone[k, k]; //Коэффициент
                    for (int j = 0; j < n + 1; j++) //j-номер столбца следующей строки после k
                        Matrix_Clone[i, j] = Matrix_Clone[i, j] - Matrix_Clone[k, j] * K; //Зануление элементов матрицы ниже первого члена, преобразованного в единицу
                }
                for (int i = 0; i < n; i++) //Обновление, внесение изменений в начальную матрицу
                    for (int j = 0; j < n + 1; j++)
                        Matrix[i, j] = Matrix_Clone[i, j];
            }

            // Обратный ход (Зануление верхнего правого угла)
            for (int k = n - 1; k > -1; k--) //k-номер строки
            {
                for (int i = n; i > -1; i--) //i-номер столбца
                    Matrix_Clone[k, i] = Matrix_Clone[k, i] / Matrix[k, k];
                for (int i = k - 1; i > -1; i--) //i-номер следующей строки после k
                {
                    double K = Matrix_Clone[i, k] / Matrix_Clone[k, k];
                    for (int j = n; j > -1; j--) //j-номер столбца следующей строки после k
                        Matrix_Clone[i, j] = Matrix_Clone[i, j] - Matrix_Clone[k, j] * K;
                }
            }

            // Отделяем от общей матрицы ответы
            double[] Answer = new double[n];
            for (int i = 0; i < n; i++)
                Answer[i] = Matrix_Clone[i, n];

            return Answer;
        }

        private static double Keq(double Kh, double Kv)
        {
            return Math.Sqrt((Kh * Math.Pow(10d, -15)) * (Kv * Math.Pow(10d, -15)));
        }

        private static double Xh(double Kh, double Kv)
        {
            return Math.Sqrt(Keq(Kh, Kv)/ Kh);
        }

        private static double Xv(double Kh, double Kv)
        {
            return Math.Sqrt(Keq(Kh, Kv) / Kv);
        }
    }
}
