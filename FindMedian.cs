using System;

namespace task2week1
{
    class Program
    {
        public static int FindMedian(int number1, int number2, int number3)
        {
            if (number1 > number3)
            {
                return Math.Max(Math.Min(number1, number2), number3);
            }
            else
            {
                return Math.Min(Math.Max(number1, number2), number3);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FindMedian(30, 20, 10));
        }
    }
}
