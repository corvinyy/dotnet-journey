using System;

namespace learning_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers: ");

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int result = FindMax(num1, num2, num3);
            Console.WriteLine($"Max = {result}");
        }

        static int FindMax(int a, int b, int c)
        {
            int max;

            if (a > b && a > c)
            {
                max = a;
            }
            else if (b > c)
            {
                max = b;
            }
            else
            {
                max = c;
            }

            return max;
        }
    }
}