using System;

namespace LessonOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result1 = 3 + 4 * 2;
            Console.WriteLine("result1 = " + result1);

            int result2 = (3 + 4) * 2;
            Console.WriteLine("result2 = " + result2);

            int remainder = 17 % 3;
            Console.WriteLine("remainder = " + remainder);

            //////////////////////////////////////////////////////

            // int divisionResult = 10 / 8; // Cannot be int because result is 1.25
            // double divisionResult = 10 / 8; // Still incorrect because it's not explicitly defined
            double divisionResult = (double)10 / 8;
            Console.WriteLine("divisionResult = " + divisionResult);

            // Can also be written with decimal numbers:
            double divisionResultAlt = 10.0 / 8;
            Console.WriteLine("divisionResult (alternative) = " + divisionResultAlt + "\n");

            //////////////////////////////////////////////////////

            // QUADRATIC FORMULA: (-b ± sqrt(b^2 - 4ac)) / 2a

            double a = 1.0, b = -3.0, c = -4.0; // coefficients of the equation

            double discriminant = (b * b) - 4.0 * a * c;
            // or
            double discriminantAlt = Math.Pow(b, 2.0) - 4.0 * a * c;

            double root1 = (-b + Math.Sqrt(discriminantAlt)) / (2 * a);  // positive root
            double root2 = (-b - Math.Sqrt(discriminantAlt)) / (2 * a);  // negative root

            Console.WriteLine("Discriminant = " + discriminantAlt);
            Console.WriteLine("Root 1 = " + root1);
            Console.WriteLine("Root 2 = " + root2 + "\n");
        }
    }
}
