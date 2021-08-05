using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Day3Ex1._2
{
    interface ICalc
    {
        int Add(params int [] list);
        int Subtract(int i, int j);
        int Multiply(int i, int j);
        int Divide(int i, int j);

    }
    class Calculator : ICalc
    {
        public int Add(params int [] list)
        {
            int sum = 0;
            foreach (int i in list)
            {
                sum = sum + i;
            }
            return sum;
        }

        public int Divide(int i, int j)
        {
            return i / j;
        }

        public int Multiply(int i, int j)
        {
            return i * j;
        }

        public int Subtract(int i, int j)
        {
            return i - j;
        }
    }

}
