using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_GenericTypes
{
    interface  IMath<T>
    {
        T Sum(T param1, T param2);
    }

    class IntMath : IMath<int>
    {
        public int Sum(int param1, int param2)
        {
            return param1 + param2;
        }
    }

    class DoubleMath : IMath<double>
    {
        public double Sum(double param1, double param2)
        {
            return param1 + param2;
        }
    }
}
