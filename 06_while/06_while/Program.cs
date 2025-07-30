using System;

namespace exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter two numbers: ");

            string[] numbers = Console.ReadLine().Split(' ');
            double x = double.Parse(numbers[0]);
            double y = double.Parse(numbers[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0.0 && y > 0.0)
                {
                    Console.WriteLine("Quadrant Q1");
                }
                else if (x < 0.0 && y > 0.0)
                {
                    Console.WriteLine("Quadrant Q2");
                }
                else if (x < 0.0 && y < 0.0)
                {
                    Console.WriteLine("Quadrant Q3");
                }
                else
                {
                    Console.WriteLine("Quadrant Q4");
                }

                Console.Write("Enter two numbers: ");
                numbers = Console.ReadLine().Split(' ');

                x = double.Parse(numbers[0]);
                y = double.Parse(numbers[1]);
            }
        }
    }
}