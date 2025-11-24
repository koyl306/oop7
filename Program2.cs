using System;

namespace _7pr
{
    class Program
    {
        static void FindMinMax<T>(T[] array, out T min, out T max) where T : IComparable<T>
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Масив не може бути порожнім");

            min = array[0];
            max = array[0];

            foreach (T item in array)
            {
                if (item.CompareTo(min) < 0)
                    min = item;
                if (item.CompareTo(max) > 0)
                    max = item;
            }
        }
        
        static void Main(string[] args)
        {
            int[] intArray = { 5, 2, 9, 1, 7 };
            FindMinMax<int>(intArray, out int intMin, out int intMax);
            Console.WriteLine($"Цілі числа: min={intMin}, max={intMax}");

            double[] doubleArray = { 3.14, 2.71, 0.5, 10.2 };
            FindMinMax<double>(doubleArray, out double doubleMin, out double doubleMax);
            Console.WriteLine($"Дійсні числа: min={doubleMin}, max={doubleMax}");

            Console.ReadKey();
        }
    }
}