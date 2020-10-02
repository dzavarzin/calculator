using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
    public class Calc
    {
        private static double currentResult = 0;

        public static double GetResult()
        {
            return currentResult;
        }

        public static void Add(double n1, double n2)
        {
            currentResult = n1 + n2;
        }

        public static void Substract(double n1, double n2)
        {
            currentResult = n1 - n2;
        }

        public static void Multiply(double n1, double n2)
        {
            currentResult = n1 * n2;
        }

        public static void Divide(double n1, double n2)
        {
            currentResult = n1 / n2;
        }
        
        public static void Clear()
        {
            currentResult = 0;
        }
    }
}
