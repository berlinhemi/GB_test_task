using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMultiplication
{
    public class Multiplicator
    {
        /// <summary>
        /// Вычисляет количество элементов массива за исключением последних нулевых
        /// [1,2,0,6,0,0] -> 4
        /// [0,1,4,3,4,0] -> 5
        /// [1,2,3,4] -> 4
        /// </summary>
        /// <param name="array">массив</param>
        /// <returns>Длина массива минус кол-во нулевых элементов в конце (если есть)  </returns>
        private static int GetRealArrayLength(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] != 0)
                {
                    return i+1;
                }
            }
            return 0;
        }

        /// <summary>
        /// Отрезает нули с конца массива (в случае наличия таковых)
        /// </summary>
        /// <param name="array">массив</param>
        /// <returns>Массив</returns>
        private static int[] RemoveTrailingZeros(int[] array)
        {
            int realLength = GetRealArrayLength(array);
            if(realLength < array.Length)
            {
                int[] reduced = new int[realLength];
                for(int i=0; i< realLength; i++)
                {
                    reduced[i] = array[i];
                }
                return reduced;        
            }
            return array;
        }

        /// <summary>
        /// Перемножение массивов
        /// </summary>
        /// <param name="a">первый массив</param>
        /// <param name="b">второй массив</param>
        /// <returns>Результирующий массив</returns>
        public static int[] MultiplyArrays(int[] a, int[] b)
        {

            if (a.Length == 0 || b.Length == 0)
            {
                throw new Exception("Array(s) can't be empty.");
            }
            a = RemoveTrailingZeros(a);
            b = RemoveTrailingZeros(b);
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
