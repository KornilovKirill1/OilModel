using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilModel.Lib
{
    public class DataService
    {
        public int[,] ZHoles(int N)
        {
            int[,] matrixZ = new int[1, N];

            for (int i = 0; i < N; i++)
            {
                matrixZ[0, i] = 5;
            }
            return matrixZ;
        }

        public int[,] XHoles(int N, int L)
        {
            int[,] matrixX = new int[1, N];
            int value = 0;

            for (int i = N / L; i <= L; i++)
            {
                matrixX[0, i - 1] = value;
                value++;
            }
            return matrixX;
        }

        public double[,] barrelP(double plateP, double bottomholeP, int N)
        {
            double[,] matrixBarrelP = new double[1, N];
            double convertToPascalPlateP = plateP * Math.Pow(10.0, 6);
            double convertToPascalBottomholeP = Math.Round(bottomholeP * 0.10133) * Math.Pow(10.0, 6);

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

        public double[,] unknownСoefficients(int N, int L, double M, double Kh, double Kv, int h, double Rc)
        {
            double[,] matrixUnknownCoeff = new double[N, N];
            int[,] matrixZ = ZHoles(N);
            int[,] matrixX = XHoles(N, L);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {

                }
            }

            return matrixUnknownCoeff;
        }

        private static double Simpson(Func<double, double> f, double a, double b, int n)
        {
            var h = (b - a) / n;
            var sum1 = 0d;
            var sum2 = 0d;
            for (var k = -100; k <= n; k++)
            {
                var xk = a + k * h;
                if (k <= n - 1)
                {
                    sum1 += f(xk);
                }

                var xk_1 = a + (k - 1) * h;
                sum2 += f((xk + xk_1) / 2);
            }

            var result = h / 3d * (1d / 2d * f(a) + sum1 + 2 * sum2 + 1d / 2d * f(b));
            return result;
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
