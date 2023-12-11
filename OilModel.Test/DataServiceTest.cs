using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using OilModel.Lib;

namespace OilModel.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidZValue()
        {
            DataService ds = new DataService();

            int N = 5;
            int[,] res = ds.ZHoles(N);

            int[,] wait = {
            { 5 },
            { 5 },
            { 5 },
            { 5 },
            { 5 }
            };
            CollectionAssert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidXValue()
        {
            DataService ds = new DataService();

            int N = 5;
            int L = 5;
            int[,] res = ds.XHoles(N, L);

            int[,] wait = {
            { 0 },
            { 1 },
            { 2 },
            { 3 },
            { 4 }
            };
            CollectionAssert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidBarrelP()
        {
            DataService ds = new DataService();

            int N = 5;
            double plateP = 15;
            double bottomholeP = 100;
            double[,] res = ds.barrelP(plateP, bottomholeP, N);

            double[,] wait = {
            { 5000000 },
            { 5000000 },
            { 5000000 },
            { 5000000 },
            { 5000000 }
            };
            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFlowRateBorisov()
        {
            DataService ds = new DataService();

            double Kh = 50;
            double Kv = 50;
            int h = 10;
            double plateP = 15;
            double bottomholeP = 100;
            double M = 0.001;
            int Rk = 1000;
            int L = 100;
            double Rc = 0.1;

            double res = ds.flowRateBorisov(Kh, Kv, h, plateP, bottomholeP, M, Rk, L, Rc);

            double wait = 342.234473;

            Assert.AreEqual(wait, res);
        }
    }
}
