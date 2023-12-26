using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZakharovaYV.Sprint1.Review.V.Lib;

namespace Tyuiu.ZakharovaYV.Sprint1.Review.V.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            double wait = 1.787;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
