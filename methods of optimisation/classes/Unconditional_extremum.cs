using MathNet.Numerics.LinearAlgebra.Double;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics;
using System;

namespace methods_of_optimisation
{
    class Unconditional_extremum
    {
        protected double epsilon1;
        protected double epsilon2;
        protected double[] vector;
        protected Func<double[], double> f;

        public Unconditional_extremum(double[] vector, Func<double[], double> f,
            double epsilon1 = 0.01, double epsilon2 = 0.015)
        {
            this.epsilon1 = epsilon1;
            this.epsilon2 = epsilon2;
            this.vector = vector;
            this.f = f;
        }

        public virtual string algorithm() { return null; }

        protected virtual Vector<double> gradient(Vector<double> vec)
        {
            double[] v = vec.ToArray();
            var vect = vec.ToArray();
            for (int i = 0; i < vec.Count; i++)
                v[i] = Differentiate.FirstPartialDerivativeFunc(f, i)(vect);
            return DenseVector.OfArray(v);
        }
    }
}