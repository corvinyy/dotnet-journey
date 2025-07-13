using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // LEARNING BASIC DATA TYPES IN C#
            // int, long, float, bool, double, char, string, 
            // byte, sbyte, object

            int x1 = 1000;
            Console.WriteLine($"x1 = {x1}");

            long x2 = 2147483648L;
            Console.WriteLine($"x2 = {x2}");

            float x3 = 4.5f;
            Console.WriteLine($"x3 = {x3}");

            double x4 = 5.5;
            Console.WriteLine($"x4 = {x4}");

            byte n1 = 255; //The maximum is 255
            n1++;          // Trying to add +1 
            Console.WriteLine($"n1 = {n1}"); // = 0

            sbyte n2 = 100;
            Console.WriteLine($"n2 = {n2}");

            bool complete = false; //0 or 1
            Console.WriteLine(complete);

            char gender = 'm'; //Only one character
            Console.WriteLine($"Gender = {gender}");

            char letter = '\u0041'; // Letter code "A"
            Console.WriteLine($"Code 0041 = {letter}");

            string name = "Corviny";  //Immutable
            Console.WriteLine($"Name = {name}");

            object obj1 = "Alex"; // accepts any value
            Console.WriteLine(obj1);

            // Getting the minimum and maximum value of integer numbers
            int minimum  = int.MinValue;
            int maximum = int.MaxValue;

            Console.WriteLine("int Minimum: " + minimum);
            Console.WriteLine("int Maximum: " + maximum);
        }
    }
}
