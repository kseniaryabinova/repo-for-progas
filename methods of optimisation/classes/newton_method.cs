using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra.Double;

namespace methods_of_optimisation.classes
{
    class newton_method : Unconditional_extremum
    {        
        private Matrix<double> H;

        public newton_method(double[] vector, Func<double[], double> f,
            double epsilon1 = 0.01, double epsilon2 = 0.015)
                : base(vector, f, epsilon1, epsilon2)
        { }               

        private void Hesse(Vector<double> vec)
        {
            H = Matrix<double>.Build.Dense(vec.Count, vec.Count);
            vector = vec.ToArray();            
            for (int i = 0; i < vec.Count; i++)
                for (int j = 0; j < vec.Count; j++)
                    H[i, j] = Differentiate.PartialDerivative(
                        Differentiate.FirstPartialDerivativeFunc(f, i), vector, j, 1);
        }

        public override string algorithm()
        {
            Vector<double> vect = DenseVector.OfArray(vector), vectorPred = vect,
                grad = vect;
            string str = "";
            int N = 1000;

            while (true)
            {
                grad = gradient(vect);
                Hesse(vect);
                vectorPred = vect;
                vect = vect + H.Inverse()*(-grad);

                var matr = H.Inverse();

                str += "\tитерация №" + (1001 - N) + 
                    "\r\nматрица Гессе: \r\n";
                for (int i = 0; i < H.ColumnCount; i++, str+="\r\n")
                    for (int j = 0; j < H.RowCount; j++)
                        str += Math.Round(H[i, j],5) + "  ";
                str += "обратная матрица Гессе: \r\n";
                for (int i = 0; i < matr.ColumnCount; i++, str += "\r\n")
                    for (int j = 0; j < matr.RowCount; j++)
                        str += Math.Round(matr[i, j], 5) + "  ";
                str += "градиент текущего x = {";
                foreach (var el in grad)
                    str += (Math.Round(el, 5)).ToString() + ";  ";
                str = str.Substring(0, str.Length - 3);
                str += "}\r\nвектор = {";
                foreach (var el in vect)
                    str += (Math.Round(el, 5)).ToString() + ";  ";
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
