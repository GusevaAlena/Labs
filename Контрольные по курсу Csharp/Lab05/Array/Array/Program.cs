using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов в массиве: ");
            int n = int.Parse(Console.ReadLine());
            int[] Array = new int[n];
            int i = 0;
            for (i = 0; i < Array.Length; i++)
            {
                Console.Write("Array [{0}]: ", i);
                Array[i] = int.Parse(Console.ReadLine());
            }
            int ArraySum = 0;
            ArraySum = Array.Sum();
            Console.WriteLine("Сумма всех элементов массива = {0} ", ArraySum);
            double AvOfArray = 0;
            AvOfArray = Array.Average();
            Console.WriteLine("Среднее значения элементов массива =" + $"{AvOfArray:.##}");
            int ArraySumPlus, ArraySumMinus;
            ArraySumPlusMinus(Array, out i, out ArraySumPlus, out ArraySumMinus);
            int ArraySumWithEvenN, ArraySumWithOddN;
            ArraySumEvenOdd(Array, out i, out ArraySumWithEvenN, out ArraySumWithOddN);
            int ArrayMax, IndexMax, ArrayMin, IndexMin;
            ArrayMaxMin(Array, out i, out ArrayMax, out IndexMax, out ArrayMin, out IndexMin);
            int ArrayProd;
            ArrayProdBetweenMaxMin(Array, out i, IndexMax, IndexMin, out ArrayProd);
            Console.WriteLine("Сумма положительных элементов массива равна: {0}", ArraySumPlus);
            Console.WriteLine("Сумма отрицательных элементов массива равна: {0}", ArraySumMinus);
            Console.WriteLine("Сумма элементов массива с четным индексом равна: {0}", ArraySumWithEvenN);
            Console.WriteLine("Сумма элементов массива с нечетным индексом равна: {0}", ArraySumWithOddN);
            Console.WriteLine("Максимальный элемент массива с индексом {0} равен: {1}", IndexMax, ArrayMax);
            Console.WriteLine("Минимальный элемент массива с индексом {0} равен: {1}", IndexMin, ArrayMin);
            Console.WriteLine("Произведение элементов массива, расположенных между максимум и минимумом, равно: {0}", ArrayProd);
            Console.ReadLine();
        }

        private static void ArrayProdBetweenMaxMin(int[] Array, out int i, int IndexMax, int IndexMin, out int ArrayProd)
        {
            ArrayProd = 1;
            int Max = IndexMax;
            int Min = IndexMin;
            if (Min > Max)
            {
                i = Min;
                Min = Max;
                Max = i;
            }
            for (i = Min + 1; i < Max; i++)
            {                  
               ArrayProd = ArrayProd * Array[i];                                                   
            }            
        }

        private static void ArrayMaxMin(int[] Array, out int i, out int ArrayMax, out int IndexMax, out int ArrayMin, out int IndexMin)
        {
            ArrayMax = Array[0];
            IndexMax = 0;
            ArrayMin = Array[0];
            IndexMin = 0;
            for (i = 1; i < Array.Length; i++)
            {
                if (ArrayMax <= Array[i])
                {
                    ArrayMax = Array[i];
                    IndexMax = i;
                }
                if (ArrayMin >= Array[i])
                {
                    ArrayMin = Array[i];
                    IndexMin = i;
                }
            }
        }

        private static void ArraySumEvenOdd(int[] Array, out int i, out int ArraySumWithEvenN, out int ArraySumWithOddN)
        {
            ArraySumWithEvenN = 0;
            ArraySumWithOddN = 0;
            for (i = 0; i < Array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    ArraySumWithEvenN = ArraySumWithEvenN + Array[i];
                }
                else
                {
                    ArraySumWithOddN = ArraySumWithOddN + Array[i];
                }
            }
        }

        private static void ArraySumPlusMinus(int[] Array, out int i, out int ArraySumPlus, out int ArraySumMinus)
        {
            ArraySumPlus = 0;
            ArraySumMinus = 0;
            for (i = 0; i < Array.Length; i++)
            {
                if (Array[i] >= 0)
                {
                    ArraySumPlus = ArraySumPlus + Array[i];
                }
                else if (Array[i] < 0)
                {
                    ArraySumMinus = ArraySumMinus + Array[i];
                }
            }
        }
    }
}
