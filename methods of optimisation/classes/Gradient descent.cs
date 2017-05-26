using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace methods_of_optimisation.classes
{

    partial class Gradient_descent_method : Unconditional_extremum
    {
        public double alpha;

        public Gradient_descent_method(double[] vector, Func<double[], double> f,
            double epsilon1 = 0.01, double epsilon2 = 0.015)
            : base(vector, f, epsilon1, epsilon2)
        { }

        protected double golden_section(Func<double, double> g)
        {
            double a = -1, b = 1, x = 0, y = 0, epsilon = 0.01;
            int i = 0;

            do
                if (i % 10 == 0)
                {
                    x = a + ((3 - Math.Sqrt(5)) / 2) * (b - a);
                    y = a + b - x;
                }
                else
                    if (g(x) < g(y))
                {
                    b = y;
                    y = x;
                    x = a + b - y;
                }
                else
                {
                    a = x;
                    x = y;
                    y = a + b - x;
                }
            while (Math.Abs(b - a) >= 2 * epsilon && --i < 1000);

            return (a + b) / 2;
        }
        
        public override string algorithm ()
        {       
            Vector<double> vect = DenseVector.OfArray(vector), vectorPred = vect, grad = vect;
            string str = "";
            int N = 1000;

            while (true)
            {
                grad = gradient(vect);
                alpha = golden_section((double x) => { return f((vect + x * (-grad)).ToArray()); });
                vectorPred = vect;
                vect = vect + alpha * (-grad);

                str += "\tитерация №" + (1001 - N) +
                    "\r\nalpha = " + Math.Round(alpha, 3) + "\r\n" + "вектор = {";
                foreach (var el in vect)
                    str += (Math.Round(el,3)).ToString() + ";  ";
                str = str.Substring(0, str.Length - 3);
                str += "}\r\n\r\n";

                if (grad.L2Norm() < epsilon1)
                    return str + "выход по основному условию";
                if ((vectorPred - vect).L2Norm() < epsilon2
                    && Math.Abs(f(vect.ToArray()) - f(vectorPred.ToArray())) < epsilon2)
                    return str + "выход по дополнительному условию";
                if (--N == 0)
                    return str + "число итераций достигло максимума";
            }
        }
    }
}
