using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMultiplication
{
    class Tests
    {
        public static void RunAllTests()
        {
            int[] result = Multiplicator.Multiply(new int[] { -1, 1 }, new int[] { 2, 1 });
            int[] right_answer = new int[] { -2, 1, 1 };
            if (Enumerable.SequenceEqual(result, right_answer))
            {
                Console.WriteLine("Test1 OK");
            }
            else
            {
                Console.WriteLine("Test1 FAILED");
            }


            result = Multiplicator.Multiply(new int[] { 1, 1, 1 }, new int[] { 1, 1, 1 });
            right_answer = new int[] { 1, 2, 3, 2, 1 };
            if (Enumerable.SequenceEqual(result, right_answer))
            {
                Console.WriteLine("Test2 OK");
            }
            else
            {
                Console.WriteLine("Test2 FAILED");
            }


            result = Multiplicator.Multiply(new int[] { 1, 1, 1 }, new int[] { 0, 0, 1, 1 });
            right_answer = new int[] { 0, 0, 1, 2, 2, 1 };
            if (Enumerable.SequenceEqual(result, right_answer))
            {
                Console.WriteLine("Test3 OK");
            }
            else
            {
                Console.WriteLine("Test3 FAILED");
            }


            try
            {
                Multiplicator.Multiply(new int[] { 1, 1, 1 }, new int[] { 1, 1, 0, 0 });
                Console.WriteLine("Test4 FAILED");
            }
            catch
            {
                Console.WriteLine("Test4 OK");
            }
            


            try
            {
                Multiplicator.Multiply(new int[] { }, new int[] { 2, 1 });
                Console.WriteLine("Test5 FAILED");
            }
            catch
            {
                Console.WriteLine("Test5 OK");
            }


            try
            {
               Multiplicator.Multiply(new int[] {1,2,3 }, new int[] {});
                Console.WriteLine("Test6 FAILED");
            }
            catch
            {
                Console.WriteLine("Test6 OK");
            }


            try
            {
                Multiplicator.Multiply(new int[] {  }, new int[] { });
                Console.WriteLine("Test7 FAILED");
            }
            catch
            {
                Console.WriteLine("Test7 OK");
            }

        }
    }
}
