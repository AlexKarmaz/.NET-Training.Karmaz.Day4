using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /// <summary>
    /// Contains the method of searching the root by Newton's method
    /// </summary>
    public class NewtonMethod
    {
        /// <summary>Finding root of specified degree of the number</summary>
        /// <param name="number">Number for which you want to search the root</param>
        /// <param name="n">Degree of root</param>
        /// <param name="precision">Precision of root</param>
        /// <returns>Root of <paramref name="n"/>-degree for the <paramref name="number"/></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static double Sqrt(double number, int n, double precision = 0.000001)
        {
            if (precision < 1e-15 || precision > 1)
            {
                throw new ArgumentOutOfRangeException(nameof(precision));
            }

            if (n < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n));
            }

            if (number < 0 && n % 2 == 0)
            {
                throw new ArgumentException();
            }

            if (Math.Abs(number) < precision)
            {
                throw new ArgumentException();
            }


            double x0, x1 = number;

            do
            {
                x0 = x1;
                x1 = x0 - (Math.Pow(x0, n) - number) / (Math.Pow(x0, n - 1) * n);
            } while (Math.Abs(x1 - x0) > precision);


            return x1;
        }
    }
}
