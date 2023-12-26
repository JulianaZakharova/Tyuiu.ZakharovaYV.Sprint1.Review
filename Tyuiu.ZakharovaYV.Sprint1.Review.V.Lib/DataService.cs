using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ZakharovaYV.Sprint1.Review.V.Lib
{
    public class DataService
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Round(Math.Pow(Math.Cos(Math.Sin(1 / x)), 2) + Math.Pow(y, x), 3);
            return res;
        }
    }
}
