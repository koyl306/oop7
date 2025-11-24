using System;

namespace _7pr
{
    class Program
    {
        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
        
        static void Main(string[] args)
        {
            double x = 3.14;
            double y = 2.71;
            Swap<double>(ref x, ref y);
            Console.WriteLine($"double: x={x} y={y}");

            string s1 = "Hello";
            string s2 = "World";
            Swap<string>(ref s1, ref s2);
            Console.WriteLine($"string: s1={s1} s2={s2}");

            Console.ReadKey();
        }
    }
}