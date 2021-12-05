using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMultiplication
{
    public class Multiplicator
    {
        public static int[] Multiply(int[] a, int[] b)
        {

            if (a.Length == 0 || b.Length == 0)
            {
                throw new Exception("Array(s) can't be empty.");
            }
            //Нет необходимости показывать, что члены с более высокими показателями степенями имеют нулевые коэффициенты.
            if (a[a.Length-1] == 0 || b[b.Length-1] == 0)
            {
                throw new Exception("Array(s) must not contain zeros at the end.");
            }
            int[] result = new int[a.Length + b.Length - 1];
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    result[i + j] += a[i] * b[j];
                }
            }
            return result;
        }
    }
}
