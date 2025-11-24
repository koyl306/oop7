using System;

namespace _7pr
{
    class Gen<T> where T : IComparable<T>
    {
        T value;

        public Gen(T val) => value = val;

        public T GetMin(T other) => value.CompareTo(other) < 0 ? value : other;

        public void ShowType() => Console.WriteLine($"Тип даних: {typeof(T)}");
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Gen<int> intObj = new Gen<int>(10);
            int intMin = intObj.GetMin(20);
            intObj.ShowType();
            Console.WriteLine($"Менше число: {intMin}");
            Console.WriteLine();

            Gen<double> doubleObj = new Gen<double>(3.14);
            double doubleMin = doubleObj.GetMin(2.71);
            doubleObj.ShowType();
            Console.WriteLine($"Менше число: {doubleMin}");

            Console.ReadKey();
        }
    }
}