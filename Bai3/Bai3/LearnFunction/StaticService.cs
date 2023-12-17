using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnFunction
{
    public static class StaticService
    {
        public static double CaculateAvg(double num1, double num2)
        {
            double result = (num1 + num2) / 2;
            return result;
        }

        public static double acc(double num1, double num2)
        {
            double acc = num1 * num2;
            return acc;
        }
    }
}
